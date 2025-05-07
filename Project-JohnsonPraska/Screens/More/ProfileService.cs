using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JohnsonPraska
{
    public static class ProfileService
    {
        private static readonly string connectionString = "server=localhost;port=3306;user id=appuser;password=password;database=emr;";

        public static DataTable GetDocNotes(string id)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @$"SELECT Employee_ID,
                                         Note,
                                         Note_ID
                                  FROM Doctor_Notes
                                  WHERE Patient_ID = {id}";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static DataTable GetPatient(string id)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @$"SELECT *
                                  FROM Patient
                                  WHERE Patient_ID = {id}";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static string GetDocName(string id)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @$"SELECT Fname,
                                         Lname
                                  FROM Employee
                                  WHERE Employee_ID = {id}";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            DataRow row = dt.Rows[0];

            return (row["Fname"].ToString() + " " + row["Lname"].ToString());
        }

        public static bool DeletePatient(int patientID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM billing_invoice WHERE patient_ID = @id", conn))
                {
                    checkCmd.Parameters.AddWithValue("@id", patientID);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {

                        MessageBox.Show(
                            "This patient is linked to billing records and cannot be deleted.",
                            "Cannot Delete Patient",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return false;
                    }
                }

                using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE patient_ID = @id", conn))
                {
                    checkCmd.Parameters.AddWithValue("@id", patientID);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {

                        MessageBox.Show(
                            "This patient is linked to an appointment and cannot be deleted.",
                            "Cannot Delete Patient",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return false;
                    }
                }

                using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM doctor_notes WHERE patient_ID = @id", conn))
                {
                    checkCmd.Parameters.AddWithValue("@id", patientID);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {

                        MessageBox.Show(
                            "This patient is linked to a doctor note and cannot be deleted.",
                            "Cannot Delete Patient",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return false;
                    }
                }

                using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM medical_record WHERE patient_ID = @id", conn))
                {
                    checkCmd.Parameters.AddWithValue("@id", patientID);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {

                        MessageBox.Show(
                            "This patient is linked to a medical record and cannot be deleted.",
                            "Cannot Delete Patient",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return false;
                    }
                }

                using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM prescription WHERE patient_ID = @id", conn))
                {
                    checkCmd.Parameters.AddWithValue("@id", patientID);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {

                        MessageBox.Show(
                            "This patient is linked to a prescription and cannot be deleted.",
                            "Cannot Delete Patient",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return false;
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand("DeletePatient", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pPatient_ID", patientID);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        }

        public static void ConfirmPatient(int patientID, string room, DateTime DOB, string address, string Fname, string Lname)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("UpdatePatient", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pPatient_ID", patientID);
                    if (room != "")
                    {
                        cmd.Parameters.AddWithValue("@pRoom", room);
                    } else
                    {
                        cmd.Parameters.AddWithValue("@pRoom", null);
                    }
                    cmd.Parameters.AddWithValue("@pDate_Of_Birth", DOB);
                    cmd.Parameters.AddWithValue("@pAddress", address);
                    cmd.Parameters.AddWithValue("@pFname", Fname);
                    cmd.Parameters.AddWithValue("@pLname", Lname);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows == 0)
                    {
                        throw new Exception("⚠️ No patient was updated! Check if the Patient_ID exists!");
                    }
                }
            }
        }
    }
}
