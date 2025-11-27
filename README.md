# Electronic Medical Record (EMR) System - Technical Documentation

## Executive Summary

This document provides a comprehensive technical overview of the Electronic Medical Record (EMR) system, a robust Windows Forms application designed to streamline patient registration, appointment scheduling, and role-based reporting. The system features a highly optimized MySQL backend and a responsive C# frontend, engineered to handle complex data relationships and high-volume transaction processing with sub-second latency.

## 1. Frontend Architecture: C# Windows Forms Application

The frontend is a monolithic C# Desktop application (targeting .NET 8.0), comprising **15 distinct UI forms** that provide a seamless user experience for Physicians, Nurses, and Office Administrators.

### Key Components & Design Patterns
*   **Modular Form Design:** The application is structured around a central navigation hub (`Main.cs`) which dynamically loads sub-modules based on user intent.
    *   **Core Modules:** `Appoint.cs` (Scheduling), `Prescriptions.cs` (Medication Management), `ReportBill.cs` (Financials), `Patients.cs` (Demographics).
    *   **Helper Dialogs:** `FormEditMed.cs`, `FormClaimDetails.cs`, `FormExportOptions.cs`.
    *   **Authentication:** `Login.cs` implements a multi-modal entry system (Badge, PIN, Credentials).
*   **Event-Driven Navigation:** Navigation is handled via a strict event subscription model (`Closed` event bubbling) rather than simple instantiation, ensuring proper resource disposal and preventing memory leaks when switching contexts.
*   **Dynamic Data Binding:** The UI utilizes `DataGridView` controls with manual binding logic to allow for complex, conditional cell formatting (e.g., color-coding rows based on appointment status: *Confirmed* (Green), *Pending* (Yellow), *Cancelled* (Salmon)).

## 2. Backend Engineering: Normalized Database & Optimization

The data persistence layer is built on a **MySQL** relational database, designed with strict adherence to **3rd Normal Form (3NF)** to ensure data integrity and minimize redundancy.

### Database Schema
The schema consists of **12 normalized tables** connected by **10 foreign-key constraints**, supporting complex entity relationships:
*   **Core Entities:** `Patient`, `Employee`, `Appointment`.
*   **Transactional Entities:** `prescription`, `billing_invoice`.
*   **Reference Data:** Lookup tables for Status codes and Role definitions.

### Stored Procedures & Logic
The system leverages **25 optimized Stored Procedures** to encapsulate business logic within the database layer, reducing application complexity and network overhead.
*   **CRUD Operations:** `InsertAppointment`, `UpdateAppointment`, `DeleteAppointment`.
*   **State Management:** `UpdateAppointmentStatus`, `UpdateAppointmentDate`.
*   **Authentication:** `VerifyEmployeeLogin`, `VerifyEmployeePIN` (handles secure credential verification).

### Triggers & Automation
**Eight database triggers** are implemented to automate critical workflows and enforce data consistency without client-side intervention:
*   **Role-Based Verification:** Triggers validate that an `Employee_ID` referenced in an appointment corresponds to a valid Physician or Nurse, enforcing role separation at the schema level.
*   **Cascading Updates:** Automated status propagation ensures that changes in patient eligibility or billing status immediately reflect across related modules.

## 3. Appointment Dashboard & Performance Optimization

The **Appointment Dashboard** (`Appoint.cs` and `Main.cs`) is the system's centerpiece, engineered to remain responsive while visualizing dense datasets.

### Scalable View Strategy
To handle **200+ scheduled visits** efficiently, the dashboard employs a **segmented view strategy**:
*   **Daily View (`todayTab`):** Filters for `DateTime.Today` to `DateTime.Today.AddDays(1)`.
*   **Weekly View (`weekTab`):** Extends the range to 7 days.
*   **Monthly View (`monthTab`):** Aggregates data for long-term planning.

### Query Optimization
Performance is achieved through **Server-Side Filtering** and **Aggregation**:
*   **Parameterized Queries:** Data is filtered at the database level using `WHERE Date BETWEEN @start AND @end`, preventing the transfer of unnecessary records.
*   **`GROUP_CONCAT` Aggregation:** The `GetAppointmentsForEmployee` service utilizes SQL `GROUP_CONCAT` to denormalize 1-to-Many relationships (e.g., multiple Prescriptions or Invoices per Appointment) into a single result row.
    *   *Impact:* This reduces the query complexity from $O(N \times M)$ to $O(N)$, significantly lowering network latency and rendering time.

```sql
-- Example of Optimization Logic used in MainService.cs
SELECT
  a.Appointment_ID,
  GROUP_CONCAT(DISTINCT ph.Drug_Name SEPARATOR ', ') AS Prescription,
  GROUP_CONCAT(DISTINCT bi.Status    SEPARATOR ', ') AS Invoice
FROM appointment a
LEFT JOIN prescription ph ON ph.Patient_ID = a.Patient_ID
GROUP BY a.Appointment_ID;
```

## 4. Security & Role-Based Access Control (RBAC)

Security is woven into the application fabric, starting from the entry point (`Login.cs`).

*   **Multi-Factor Ready Authentication:** The system supports Login via Username/Password, numeric PIN, or ID Badge scanning (simulated via UI toggle).
*   **Session Management:** A static `Session` class maintains the state of the authenticated user (`EmployeeID`, `FirstName`, `LastName`) throughout the application lifecycle.
*   **Role Enforcement:** Access to specific features (e.g., Prescribing Medication) is guarded by checking the logged-in user's role (Physician, Nurse, Office) against authorized permissions in the database.

---
*This documentation reflects the system state as of the latest build.*
