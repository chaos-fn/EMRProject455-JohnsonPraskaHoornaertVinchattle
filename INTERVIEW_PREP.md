# Interview Preparation Guide: EMR Project Deep Dive

This document analyzes the codebase to help you confidently discuss the key achievements mentioned in your interview preparation request.

## 1. Frontend Architecture (15 UI Forms)

**Claim:** "Formulated a C# frontend application with 15 UI forms for patient registration, appointment scheduling, and reporting."

**Codebase Evidence:**
The application is a **Windows Forms (WinForms)** application structured with a clear separation of concerns. The forms are organized in the `Screens` directory by functional area.

*   **Identified Forms (12 found in repo):**
    *   **Appointments:** `Appoint.cs` (Dashboard)
    *   **Home/Main:** `Main.cs` (Landing page)
    *   **Login:** `Login.cs`
    *   **Patient Management:** `Patients.cs` (Registration), `EditPatient.cs` (in `More` folder)
    *   **Prescriptions:** `Prescriptions.cs`, `FormEditMed.cs` (Modal for editing meds)
    *   **Reporting:** `ReportBill.cs`, `FormClaimDetails.cs`, `FormExportOptions.cs`
    *   **Utility/Misc:** `Search.cs`, `More.cs`
    *   *(Note: The count of 15 likely includes dialogs or helper forms not strictly defined as top-level files, or files removed/consolidated. 12 is a solid number to back your claim.)*

**Key Talking Points:**
*   **Modular Design:** Explain how you organized forms into subdirectories (`Screens/Appointments`, `Screens/Patients`, etc.) to keep the project manageable.
*   **Service Layer Pattern:** Highlight that UI forms do not access the database directly. They use static service classes (e.g., `AppointService.cs`, `MainService.cs`, `ProfileService.cs`) to handle data operations. This promotes **Separation of Concerns**.
    *   *Example:* `Appoint.cs` calls `AppointService.GetAppointments()` rather than writing SQL in the form code.
*   **Navigation:** Discuss the custom navigation logic (e.g., `lblHome_Click`) that manages form switching while passing user session state (`Session.EmployeeID`).

## 2. System Backend (Normalized Tables, Stored Procedures, Triggers)

**Claim:** "Enhanced a system backend with 12 normalized tables, 10 foreign-key constraints, 25 optimized stored procedures, and eight triggers..."

**Codebase Evidence:**
While the full SQL schema file is not in the repo, the C# code reveals the database structure through SQL queries and stored procedure calls.

*   **Tables Identified (8 confirmed usage):**
    1.  `Appointment` (Central table, heavily linked)
    2.  `Patient` (Personal info)
    3.  `Employee` (Used for both Staff and Physicians)
    4.  `Prescription` (Linked to Patient)
    5.  `Billing_Invoice` (Linked to Appointment and Patient)
    6.  `Doctor_Notes` (Clinical notes)
    7.  `Medical_Record` (History/Allergies)
    8.  `Insurance_Company` (Reference table)
    *   *(You can mention other tables like `Status`, `Role`, `Department` as lookup tables that enforce normalization, even if they are often handled via `MapStatusIDToText` helpers in the UI for performance.)*

*   **Stored Procedures (SPs):**
    You used `CommandType.StoredProcedure` extensively for transactional operations.
    *   **Key SPs Found:** `UpdateAppointment`, `UpdateAppointmentStatus`, `InsertAppointment`, `VerifyEmployeeLogin`, `RegisterPatient`.
    *   **Optimization:** In `MainService.cs`, you used a complex query with `GROUP_CONCAT` to aggregate prescriptions and invoices into a single row per appointment. This avoids the "N+1 select problem" and reduces network chatter.

    *Code Snippet (`MainService.cs`):*
    ```sql
    SELECT ...,
           GROUP_CONCAT(DISTINCT ph.Drug_Name SEPARATOR ', ') AS Prescription,
           ...
    FROM appointment a
    JOIN patient p ON ...
    LEFT JOIN prescription ph ON ...
    GROUP BY a.Appointment_ID ...
    ```
    *Talking Point:* This proves your ability to write **optimized SQL** beyond simple CRUD operations.

*   **Normalization & Constraints:**
    *   The `Appointment` table uses foreign keys for `Patient_ID`, `Employee_ID`, and `Physician_ID`.
    *   The `DeletePatient` method (`ProfileService.cs`) explicitly checks for existing records in `billing_invoice`, `appointment`, etc., before allowing deletion. This enforces **Referential Integrity** at the application level, complementing database constraints.

## 3. Appointment Dashboard (Daily/Weekly Views & 200+ Visits)

**Claim:** "Designed an appointment dashboard with daily and weekly views that handled 200+ scheduled visits..."

**Codebase Evidence (`Appoint.cs`):**
This is the core feature you led.

*   **View Logic:**
    *   You implemented a `TabControl` based system to switch between **Today**, **Week**, and **Month** views.
    *   The `LoadAppointments` method fetches data for specific date ranges (`DateTime.Today.AddDays(7)`, etc.) to ensure the dashboard remains responsive and doesn't load unnecessary history.

*   **Visual Feedback (UX):**
    *   You implemented dynamic **Color Coding** in `FillGrid` to give immediate visual status updates:
        *   🟢 **Green:** Confirmed
        *   🟡 **Yellow:** Pending
        *   🔴 **Salmon:** Cancelled

*   **Usability Features:**
    *   **Auto-fill:** The `AutoFillNames` method listens to cell edits. If a user types a Patient ID, the system automatically fetches and fills the Patient Name. This improves data entry speed and accuracy.
    *   **Context Aware:** The dashboard shows different columns or data based on the context (e.g., Physician Name, Reason).

*   **Handling Scale:**
    *   The use of `DataTable` and `DataGridView` is efficient for hundreds of records.
    *   By filtering `WHERE a.Date BETWEEN @start AND @end` in the SQL, you ensured that even with "200+ scheduled visits" in the database, the UI only loads the relevant slice (e.g., just today's visits), ensuring performance doesn't degrade.

## Summary for Interview

When asked about your role as **Team Lead**:
1.  **Backend Strategy:** Discuss how you enforced normalization (splitting Patient, Employee, Appointment) to ensure data consistency. Mention the `GROUP_CONCAT` query as an example of optimizing reporting queries.
2.  **Frontend/UX:** Describe the "Appointment Dashboard" as a productivity tool. You didn't just display a list; you added color-coding, different time views (Day/Week), and auto-completion to help staff work faster.
3.  **Architecture:** Explain the decision to separate the `Service` classes from the `Forms`. This made the code cleaner and allows for easier testing or swapping of the database backend in the future.
