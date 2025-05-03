using System;
using System.Collections.Generic;
using System.Drawing;
using MySql.Data.MySqlClient;
using static Project_JohnsonPraska.Screens.Prescriptions.prescriptionService;

namespace Project_JohnsonPraska.Screens.Prescriptions
{

    public class Prescription
    {
        public int PrescriptionID { get; set; }
        public int PatientID { get; set; }
        public int Quantity { get; set; }
        public string Instruction { get; set; }
        public string DrugName { get; set; }
        public string Dosage { get; set; }
        public string Route { get; set; }
        public string Frequency { get; set; }
        public bool Filled { get; set; }
    }

    public class Patient
    {
        public int PatientID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

    }


    public class prescriptionService
    {
        private readonly string _connString =
              "server=localhost;port=3306;user id=appuser;password=password;database=emr;";

        public Patient? GetPatientById(int id)
        {
            using var cn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(@"
                SELECT Patient_ID, Fname, Lname
                  FROM Patient
                 WHERE Patient_ID = @id", cn);

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

        public List<Prescription> GetPrescriptions(int patientId)
        {
            var list = new List<Prescription>();
            using var conn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(@"
        SELECT Prescription_ID,
               Patient_ID,
               Quantity,
               Instruction,
               Drug_Name,
               Dosage,
               Route,
               Frequency,
               Filled
          FROM Prescription
         WHERE Patient_ID = @pid
      ORDER BY Prescription_ID DESC;", conn);
            cmd.Parameters.AddWithValue("@pid", patientId);
            conn.Open();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int ord;

                var rx = new Prescription
                {
                    PrescriptionID = reader.GetInt32(reader.GetOrdinal("Prescription_ID")),
                    PatientID = reader.GetInt32(reader.GetOrdinal("Patient_ID")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),

                    // Required non-null fields
                    DrugName = reader.GetString(reader.GetOrdinal("Drug_Name")),
                    Dosage = reader.GetString(reader.GetOrdinal("Dosage")),
                    Filled = reader.GetBoolean(reader.GetOrdinal("Filled")),

                    // Nullable fields—check for NULL
                    Route = !reader.IsDBNull(ord = reader.GetOrdinal("Route"))
                                ? reader.GetString(ord)
                                : string.Empty,

                    Frequency = !reader.IsDBNull(ord = reader.GetOrdinal("Frequency"))
                                ? reader.GetString(ord)
                                : string.Empty,

                    Instruction = !reader.IsDBNull(ord = reader.GetOrdinal("Instruction"))
                                ? reader.GetString(ord)
                                : string.Empty
                };

                list.Add(rx);
            }
            return list;
        }

        public void AddPrescription(Prescription rx)
        {
            using var cn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(@"
                INSERT INTO Prescription
                    (Patient_ID, Quantity, Instruction, Drug_Name, Dosage, Route, Frequency, Filled)
                    VALUES
                        (@pid,@qty,@instr,@drug,@dos,@route,@freq,@filled);", cn);

            cmd.Parameters.AddWithValue("@pid", rx.PatientID);
            cmd.Parameters.AddWithValue("@qty", rx.Quantity);
            cmd.Parameters.AddWithValue("@instr", rx.Instruction);
            cmd.Parameters.AddWithValue("@drug", rx.DrugName);
            cmd.Parameters.AddWithValue("@dos", rx.Dosage);
            cmd.Parameters.AddWithValue("@filled", rx.Filled);
            cmd.Parameters.AddWithValue("@route", rx.Route);
            cmd.Parameters.AddWithValue("@freq", rx.Frequency);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void UpdatePrescription(Prescription rx)
        {
            using var cn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(@"
                UPDATE Prescription
                        SET Quantity    = @qty,
                        Instruction = @instr,
                        Drug_Name   = @drug,
                        Dosage      = @dos,
                        Route       = @route,
                        Frequency   = @freq,
                        Filled      = @filled
                        WHERE Prescription_ID = @rid", cn);

            cmd.Parameters.AddWithValue("@qty", rx.Quantity);
            cmd.Parameters.AddWithValue("@instr", rx.Instruction);
            cmd.Parameters.AddWithValue("@drug", rx.DrugName);
            cmd.Parameters.AddWithValue("@dos", rx.Dosage);
            cmd.Parameters.AddWithValue("@filled", rx.Filled);
            cmd.Parameters.AddWithValue("@rid", rx.PrescriptionID);
            cmd.Parameters.AddWithValue("@route", rx.Route);
            cmd.Parameters.AddWithValue("@freq", rx.Frequency);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeletePrescription(int rxId)
        {
            using var cn = new MySqlConnection(_connString);
            using var cmd = new MySqlCommand(
                "DELETE FROM Prescription WHERE Prescription_ID = @rid;", cn);

            cmd.Parameters.AddWithValue("@rid", rxId);
            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
    public static class UserService
    {
        private static readonly string _conn =
            "server=localhost;port=3306;user id=appuser;password=password;database=emr;";

        public static int GetCurrentUserRole()
        {
            using var cn = new MySqlConnection(_conn);
            using var cmd = new MySqlCommand(@"
            SELECT Role_ID
              FROM Employee
             WHERE Employee_ID = @eid;", cn);

            cmd.Parameters.AddWithValue("@eid", Project_JohnsonPraska.Global.Session.EmployeeID);
            cn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
        }
    }
}

