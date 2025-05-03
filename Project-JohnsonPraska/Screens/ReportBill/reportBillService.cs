using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Project_JohnsonPraska.Screens.ReportBill
{
    public class BillingInvoice
    {
        public int InvoiceID { get; set; }
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
    public class Appointment
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Physician { get; set; }
        public string Status { get; set; }
    }

    public class PrescriptionSummary
    {
        public string DrugName { get; set; }
        public string Dosage { get; set; }
        public string Route { get; set; }
        public string Frequency { get; set; }
        public bool Filled { get; set; }
    }

    public class DoctorNote
    {
        public int NoteID { get; set; }
        public string Snippet { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
    }

    public class MedicalRecord
    {
        public string MedicalHistory { get; set; }
        public string Allergies { get; set; }
    }

    public class InsuranceCompany
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class BillingInvoiceRepository
    {
        private readonly string _connString =
            "server=localhost;port=3306;user id=appuser;password=password;database=emr;";

        public List<BillingInvoice> GetInvoicesByPatient(
            int patientId,
            DateTime startDate,
            DateTime endDate)
        {
            var list = new List<BillingInvoice>();
            using var cn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(@"
                SELECT BillingInvoice_ID, Appointment_ID, Patient_ID,
                       Description, Price, Date, Status
                  FROM Billing_Invoice
                 WHERE Patient_ID = @pid
                   AND Date       BETWEEN @start AND @end
              ORDER BY Date DESC;", cn);

            cmd.Parameters.AddWithValue("@pid", patientId);
            cmd.Parameters.AddWithValue("@start", startDate);
            cmd.Parameters.AddWithValue("@end", endDate);
            cn.Open();

            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new BillingInvoice
                {
                    InvoiceID = rdr.GetInt32(0),
                    AppointmentID = rdr.GetInt32(1),
                    PatientID = rdr.GetInt32(2),
                    Description = rdr.GetString(3),
                    Price = rdr.GetDecimal(4),
                    Date = rdr.GetDateTime(5),
                    Status = rdr.GetString(6)
                });
            }
            return list;
        }

        public BillingInvoice? GetInvoiceById(int invoiceId)
        {
            using var cn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(@"
        SELECT BillingInvoice_ID,
               Appointment_ID,
               Patient_ID,
               Description,
               Price,
               Date,
               Status
          FROM Billing_Invoice
         WHERE BillingInvoice_ID = @id
        ", cn);
            cmd.Parameters.AddWithValue("@id", invoiceId);
            cn.Open();
            using var rdr = cmd.ExecuteReader();
            if (!rdr.Read()) return null;

            return new BillingInvoice
            {
                InvoiceID = rdr.GetInt32(0),
                AppointmentID = rdr.GetInt32(1),
                PatientID = rdr.GetInt32(2),
                Description = rdr.GetString(3),
                Price = rdr.GetDecimal(4),
                Date = rdr.GetDateTime(5),
                Status = rdr.GetString(6),
            };
        }

        public void AddInvoice(BillingInvoice inv)
        {
            using var cn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(@"
                INSERT INTO Billing_Invoice
                  (Appointment_ID, Patient_ID, Description, Price, Date, Status)
                VALUES
                  (@app,@pid,@desc,@price,@date,@status);", cn);

            cmd.Parameters.AddWithValue("@app", inv.AppointmentID);
            cmd.Parameters.AddWithValue("@pid", inv.PatientID);
            cmd.Parameters.AddWithValue("@desc", inv.Description);
            cmd.Parameters.AddWithValue("@price", inv.Price);
            cmd.Parameters.AddWithValue("@date", inv.Date);
            cmd.Parameters.AddWithValue("@status", inv.Status);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void UpdateInvoice(BillingInvoice inv)
        {
            using var cn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(@"
                UPDATE Billing_Invoice
                   SET Appointment_ID = @app,
                       Patient_ID     = @pid,
                       Description    = @desc,
                       Price          = @price,
                       Date           = @date,
                       Status         = @status
                 WHERE BillingInvoice_ID = @bid;", cn);

            cmd.Parameters.AddWithValue("@app", inv.AppointmentID);
            cmd.Parameters.AddWithValue("@pid", inv.PatientID);
            cmd.Parameters.AddWithValue("@desc", inv.Description);
            cmd.Parameters.AddWithValue("@price", inv.Price);
            cmd.Parameters.AddWithValue("@date", inv.Date);
            cmd.Parameters.AddWithValue("@status", inv.Status);
            cmd.Parameters.AddWithValue("@bid", inv.InvoiceID);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteInvoice(int invoiceId)
        {
            using var cn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(
                "DELETE FROM Billing_Invoice WHERE BillingInvoice_ID = @bid;", cn);

            cmd.Parameters.AddWithValue("@bid", invoiceId);
            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public class Patient
        {
            public int PatientID { get; set; }
            public string Fname { get; set; }
            public string Lname { get; set; }
        }

        public class PatientService
        {
            private readonly string _conn =
                "server=localhost;port=3306;user id=appuser;password=password;database=emr;";

            public Patient? GetPatientById(int id)
            {
                using var cn = new MySqlConnection(_conn);
                using var cmd = new MySqlCommand(
                    "SELECT Patient_ID, Fname, Lname FROM Patient WHERE Patient_ID = @id", cn);
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();

                using var rdr = cmd.ExecuteReader();
                if (!rdr.Read()) return null;

                return new Patient
                {
                    PatientID = rdr.GetInt32(0),
                    Fname = rdr.GetString(1),
                    Lname = rdr.GetString(2)
                };
            }
        }
    }
    public class ReportBillService
    {
        private readonly string _conn =
            "server=localhost;port=3306;user id=appuser;password=password;database=emr;";

        public List<Appointment> GetRecentAppointments(
int patientId,
DateTime startDate,
DateTime endDate,
int limit = 10)
        {
            var list = new List<Appointment>();
            using var cn = new MySqlConnection(_conn);
            using var cmd = new MySqlCommand(@"
        SELECT a.Date,
               a.Type,
               CONCAT(e.Fname,' ',e.Lname) AS Physician,
               CASE a.Status_ID
                 WHEN 1 THEN 'Pending'
                 WHEN 2 THEN 'Confirmed'
                 WHEN 3 THEN 'Canceled'
               END AS Status
          FROM Appointment a
          JOIN Employee e ON a.Physician_ID = e.Employee_ID
         WHERE a.Patient_ID = @pid
           AND a.Date       BETWEEN @start AND @end
      ORDER BY a.Date DESC
         LIMIT @lim;", cn);

            cmd.Parameters.AddWithValue("@pid", patientId);
            cmd.Parameters.AddWithValue("@start", startDate);
            cmd.Parameters.AddWithValue("@end", endDate);
            cmd.Parameters.AddWithValue("@lim", limit);

            cn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Appointment
                {
                    Date = rdr.GetDateTime(0),
                    Type = rdr.GetString(1),
                    Physician = rdr.GetString(2),
                    Status = rdr.GetString(3),
                });
            }
            return list;
        }

        public List<PrescriptionSummary> GetRecentPrescriptions(int patientId, int limit = 10)
        {
            var list = new List<PrescriptionSummary>();
            using var cn = new MySqlConnection(_conn);
            using var cmd = new MySqlCommand(@"
                SELECT Drug_Name, Dosage, Route, Frequency, Filled
                  FROM Prescription
                 WHERE Patient_ID = @pid
              ORDER BY Prescription_ID DESC
                 LIMIT @lim;", cn);

            cmd.Parameters.AddWithValue("@pid", patientId);
            cmd.Parameters.AddWithValue("@lim", limit);
            cn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new PrescriptionSummary
                {
                    DrugName = rdr.GetString(0),
                    Dosage = rdr.GetString(1),
                    Route = rdr.IsDBNull(2) ? "" : rdr.GetString(2),
                    Frequency = rdr.IsDBNull(3) ? "" : rdr.GetString(3),
                    Filled = rdr.GetBoolean(4),
                });
            }
            return list;
        }

        public List<DoctorNote> GetRecentNotes(int patientId, int limit = 5)
        {
            var list = new List<DoctorNote>();
            using var cn = new MySqlConnection(_conn);
            using var cmd = new MySqlCommand(@"
        SELECT 
            n.Note_ID,
            LEFT(n.Note,50) AS Snippet,
            CONCAT(e.Fname,' ',e.Lname) AS Author
          FROM Doctor_Notes n
          JOIN Employee e ON n.Employee_ID = e.Employee_ID
         WHERE n.Patient_ID = @pid         
      ORDER BY n.Note_ID DESC
         LIMIT @lim;", cn);

            cmd.Parameters.AddWithValue("@pid", patientId);
            cmd.Parameters.AddWithValue("@lim", limit);
            cn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new DoctorNote
                {
                    NoteID = rdr.GetInt32(0),
                    Snippet = rdr.GetString(1),
                    Author = rdr.GetString(2),
                    // Date if you have a timestamp
                });
            }
            return list;
        }

        public MedicalRecord? GetRecord(int patientId)
        {
            using var cn = new MySqlConnection(_conn);
            using var cmd = new MySqlCommand(@"
                SELECT Medical_History, Allergies
                  FROM Medical_Record
                 WHERE Patient_ID = @pid;", cn);

            cmd.Parameters.AddWithValue("@pid", patientId);
            cn.Open();
            using var rdr = cmd.ExecuteReader();
            if (!rdr.Read()) return null;

            return new MedicalRecord
            {
                MedicalHistory = rdr.IsDBNull(0) ? "" : rdr.GetString(0),
                Allergies = rdr.IsDBNull(1) ? "" : rdr.GetString(1)
            };
        }

        public List<InsuranceCompany> GetAllInsuranceCompanies()
        {
            var list = new List<InsuranceCompany>();
            using var cn = new MySqlConnection(_conn);
            using var cmd = new MySqlCommand(@"
        SELECT name, address, phone_number
        FROM insurance_company;", cn);

            cn.Open();
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new InsuranceCompany
                {
                    Name = rdr.GetString(0),
                    Address = rdr.GetString(1),
                    PhoneNumber = rdr.GetString(2),
                });
            }
            return list;
        }
    }
}