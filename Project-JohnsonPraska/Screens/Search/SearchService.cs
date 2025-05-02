using MySql.Data.MySqlClient;
using Project_JohnsonPraska.Screens.Prescriptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JohnsonPraska
{
    public static class SearchService
    {
        private static readonly string connectionString = "server=localhost;port=3306;user id=appuser;password=password;database=emr;";

        public static DataTable GetPatients(string filter)
        {
            DataTable dt = new DataTable();
            string order = "ASC";
            if (filter == "Date_Of_Birth") order = "DESC";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @$"SELECT Patient.Patient_ID,
                                        Patient.Fname,
                                        Patient.Lname,
                                        Patient.Date_Of_Birth,
                                        Patient.Room
                                 FROM Patient
                                 ORDER BY {filter} {order}";
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

        public static DataTable SearchByName(string name)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @$"SELECT Patient_ID,
                                         Fname,
                                         Lname,
                                         Date_Of_Birth,
                                         Room
                                 FROM Patient
                                 WHERE Fname LIKE ""{name}%""";
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
    }
}

