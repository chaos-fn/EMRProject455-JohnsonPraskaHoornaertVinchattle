using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Project_JohnsonPraska
{
    public static class AppointService
    {
        private static readonly string connectionString = "server=localhost;port=3306;user id=appuser;password=password;database=emr;";

        public static DataTable GetAppointments(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT Appointment.Appointment_ID, Appointment.Date, 
                                        Appointment.Patient_ID,
                                        Patient.Fname AS PatientName, 
                                        Appointment.Physician_ID, 
                                        Appointment.Type AS Reason, 
                                        Appointment.Employee_ID,
                                        Employee.Fname AS EmployeeName, 
                                        Appointment.Status_ID
                                 FROM Appointment
                                 JOIN Patient ON Appointment.Patient_ID = Patient.Patient_ID
                                 JOIN Employee ON Appointment.Employee_ID = Employee.Employee_ID
                                 WHERE Appointment.Date BETWEEN @start AND @end
                                 ORDER BY Appointment.Date ASC;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@start", startDate);
                    cmd.Parameters.AddWithValue("@end", endDate);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static void ConfirmAppointment(int appointmentID, int patientID, int employeeID, int physicianID, string type, DateTime date)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("UpdateAppointment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pAppointment_ID", appointmentID);
                    cmd.Parameters.AddWithValue("@pStatus_ID", 2); // Confirmed
                    cmd.Parameters.AddWithValue("@pEmployee_ID", employeeID);
                    cmd.Parameters.AddWithValue("@pPatient_ID", patientID);
                    cmd.Parameters.AddWithValue("@pType", type);
                    cmd.Parameters.AddWithValue("@pDate", date);
                    cmd.Parameters.AddWithValue("@pPhysician_ID", physicianID);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows == 0)
                    {
                        throw new Exception("⚠️ No appointment was updated! Check if the Appointment_ID exists!");
                    }
                }
            }
        }


        public static void CancelAppointment(int appointmentID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("UpdateAppointmentStatus", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pAppointment_ID", appointmentID);
                    cmd.Parameters.AddWithValue("@pStatus_ID", 3); 
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void RescheduleAppointment(int appointmentID, DateTime newDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("UpdateAppointmentDate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pAppointment_ID", appointmentID);
                    cmd.Parameters.AddWithValue("@pDate", newDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool DeleteAppointment(int appointmentID)
{
    using (MySqlConnection conn = new MySqlConnection(connectionString))
    {
        conn.Open();

        using (MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM billing_invoice WHERE Appointment_ID = @id", conn))
        {
            checkCmd.Parameters.AddWithValue("@id", appointmentID);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
               
                MessageBox.Show(
                    "This appointment is linked to billing records and cannot be deleted.\n\nPlease cancel the appointment instead.",
                    "Cannot Delete Appointment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false; 
            }
        }

        using (MySqlCommand cmd = new MySqlCommand("DeleteAppointment", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pAppointment_ID", appointmentID);
            cmd.ExecuteNonQuery();
        }

        return true; 
    }
}



        public static void InsertAppointment(int patientID, int physicianID, string type, int employeeID, DateTime date)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("InsertAppointment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pStatus_ID", 2); // 1 = Confirmed
                    cmd.Parameters.AddWithValue("@pEmployee_ID", employeeID);
                    cmd.Parameters.AddWithValue("@pPatient_ID", patientID);
                    cmd.Parameters.AddWithValue("@pType", type);
                    cmd.Parameters.AddWithValue("@pDate", date);
                    cmd.Parameters.AddWithValue("@pPhysician_ID", physicianID);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static string GetPatientNameByID(int patientID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT Fname FROM Patient WHERE Patient_ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", patientID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "";
                }
            }
        }

        public static string GetEmployeeNameByID(int employeeID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT Fname FROM Employee WHERE Employee_ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", employeeID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "";
                }
            }
        }

        public static bool DoesPatientExist(int patientID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Patient WHERE Patient_ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", patientID);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public static bool DoesEmployeeExist(int employeeID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Employee WHERE Employee_ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", employeeID);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public static bool DoesPhysicianExist(int physicianID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Employee WHERE Employee_ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", physicianID);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }


    }
}
