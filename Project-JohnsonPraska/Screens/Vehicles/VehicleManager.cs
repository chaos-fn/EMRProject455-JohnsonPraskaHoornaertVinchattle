using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_JohnsonPraska.Screens.Vehicles
{
    internal class DataManager
    {
        public static List<string> Vehicles { get; } = new List<string>
        {
            "Connor's Car",
            "Matthew's Car"
        };
        public static List<string> Drivers { get; } = new List<string>
        {
            "Connor Praska",
            "Matthew Johnson"
        };

        public static event Action VehiclesUpdated;
        public static event Action DriversUpdated;
        public static event Action<string> AnomalyDetected;

        public static void NotifyForms()
        {
            VehiclesUpdated?.Invoke();
            DriversUpdated?.Invoke();
        }
        public static void SimulateAnomaly(string message)
        {
            AnomalyDetected?.Invoke(message);
        }
    }
}
