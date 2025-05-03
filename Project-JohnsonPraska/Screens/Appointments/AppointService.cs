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
            using (var conn = new MySqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = @"
            SELECT 
                a.Appointment_ID,
                a.Date,
                a.Patient_ID,
                p.Fname AS PatientName,
                
                a.Physician_ID,
                phy.Fname AS PhysicianName,     -- <— new alias
                
                a.Type       AS Reason,
                a.Employee_ID,
                emp.Fname    AS EmployeeName,
                a.Status_ID
            FROM Appointment a
            JOIN Patient  p   ON a.Patient_ID    = p.Patient_ID
            JOIN Employee emp ON a.Employee_ID   = emp.Employee_ID
            JOIN Employee phy ON a.Physician_ID  = phy.Employee_ID  -- <— second join
            WHERE a.Date BETWEEN @start AND @end
            ORDER BY a.Date ASC;
        ";
                cmd.Parameters.AddWithValue("@start", startDate);
                cmd.Parameters.AddWithValue("@end", endDate);

                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(dt);
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


/* 
 * -- 1. Create the user if it doesn't exist
CREATE USER IF NOT EXISTS 'appuser'@'localhost' IDENTIFIED BY 'password'; 

-- 2. Use the correct database
USE emr;

DELIMITER //

CREATE PROCEDURE UpdateAppointment(
    IN pAppointment_ID INT,
    IN pStatus_ID INT,
    IN pEmployee_ID INT,
    IN pPatient_ID INT,
    IN pType VARCHAR(255),
    IN pDate DATETIME,
    IN pPhysician_ID INT
)
BEGIN
    UPDATE Appointment
    SET 
        Status_ID = pStatus_ID,
        Employee_ID = pEmployee_ID,
        Patient_ID = pPatient_ID,
        Type = pType,
        Date = pDate,
        Physician_ID = pPhysician_ID
    WHERE Appointment_ID = pAppointment_ID;
END //

DELIMITER ;


DELIMITER //

CREATE PROCEDURE UpdateAppointmentStatus(
    IN pAppointment_ID INT,
    IN pStatus_ID INT
)
BEGIN
    UPDATE Appointment
    SET Status_ID = pStatus_ID
    WHERE Appointment_ID = pAppointment_ID;
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE UpdateAppointmentDate(
    IN pAppointment_ID INT,
    IN pDate DATETIME
)
BEGIN
    UPDATE Appointment
    SET Date = pDate
    WHERE Appointment_ID = pAppointment_ID;
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE DeleteAppointment(
    IN pAppointment_ID INT
)
BEGIN
    DELETE FROM Appointment
    WHERE Appointment_ID = pAppointment_ID;
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE InsertAppointment(
    IN pStatus_ID INT,
    IN pEmployee_ID INT,
    IN pPatient_ID INT,
    IN pType VARCHAR(255),
    IN pDate DATETIME,
    IN pPhysician_ID INT
)
BEGIN
    INSERT INTO Appointment (Status_ID, Employee_ID, Patient_ID, Type, Date, Physician_ID)
    VALUES (pStatus_ID, pEmployee_ID, pPatient_ID, pType, pDate, pPhysician_ID);
END //

DELIMITER ;






-- 3. Grant SELECT permission on all tables
GRANT SELECT ON emr.* TO 'appuser'@'localhost';

-- 4. Grant EXECUTE permission on all stored procedures and functions (database-wide)
GRANT EXECUTE ON emr.* TO 'appuser'@'localhost';

GRANT EXECUTE ON emr.* TO 'appuser'@'localhost';

-- 5. Apply privilege changes
FLUSH PRIVILEGES;

-- 6. Confirm the granted permissions
SHOW GRANTS FOR 'appuser'@'localhost';







*/