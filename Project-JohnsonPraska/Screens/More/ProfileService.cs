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
                                         Note
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
    }
}
