using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Project_JohnsonPraska.Screens.Main
{
    public static class MainService
    {
        private static readonly string connectionString =
            "server=localhost;port=3306;user id=appuser;password=password;database=emr;";
        public static DataTable GetAppointmentsForEmployee(int physicianID, DateTime start, DateTime end)
        {
            var dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = @"
                    SELECT
                        a.Appointment_ID   AS Appointment_ID,
                        a.Date             AS Date,
                        p.Fname            AS PatientFirst,
                        p.Lname            AS PatientLast,
                        TIMESTAMPDIFF(YEAR, p.Date_Of_Birth, CURDATE()) AS Age,
                        ph.Drug_Name       AS Prescription,
                        COALESCE(bi.Status, '')          AS Invoice,
                        a.Type             AS Reason,
                        CONCAT(emp.Fname, ' ', emp.Lname) AS EmployeeName,
                        a.Status_ID        AS Status_ID
                    FROM appointment a
                    JOIN patient p ON a.Patient_ID = p.Patient_ID
                    JOIN employee emp ON a.Employee_ID = emp.Employee_ID
                    LEFT JOIN prescription ph ON ph.Patient_ID = a.Patient_ID
                    LEFT JOIN billing_invoice bi ON bi.Appointment_ID = a.Appointment_ID
                    WHERE a.Physician_ID = @physID
                      AND a.Date        >= @start
                      AND a.Date        <  @end
                    ORDER BY a.Date;
                ";
                cmd.Parameters.AddWithValue("@physID", physicianID);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public static bool UpdateAppointmentStatus(int appointmentID, int statusID)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("UpdateAppointmentStatus", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pAppointment_ID", appointmentID);
                    cmd.Parameters.AddWithValue("@pStatus_ID", statusID);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
