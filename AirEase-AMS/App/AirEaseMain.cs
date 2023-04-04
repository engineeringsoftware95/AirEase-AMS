using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Entity.User.Employees;

namespace AirEase_AMS.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Customer testCust = new();
            Accountant testAcc = new();
            FlightManager fMan = new();
            LoadEngineer loadEngineer = new();
            MarketManager marketManager = new();
            Console.WriteLine("Customer UID :" + testCust.GenerateUniqueId());
            Console.WriteLine("Accountant UID :" + testAcc.GenerateUniqueId());
            Console.WriteLine("FlightMan UID :" + fMan.GenerateUniqueId());
            Console.WriteLine("MarkMan UID :" + marketManager.GenerateUniqueId());
            Console.WriteLine("Load Eng UID :" + loadEngineer.GenerateUniqueId());
            Console.WriteLine();
            Console.WriteLine("Thank you for playing Wing Commander");
        }
    }
}