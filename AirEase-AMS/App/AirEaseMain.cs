using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Entity.User.Employees;
using AirEase_AMS.Interface;
using Microsoft.Data.SqlClient;
using System.Data;

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
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new Login());

            /*Customer testCust = new();
            Accountant testAcc = new();
            FlightManager fMan = new();
            LoadEngineer loadEngineer = new();
            MarketManager marketManager = new();
            Console.WriteLine("Customer UID :" + testCust.GenerateId());
            Console.WriteLine("Accountant UID :" + testAcc.GenerateId());
            Console.WriteLine("FlightMan UID :" + fMan.GenerateId());
            Console.WriteLine("MarkMan UID :" + marketManager.GenerateId());
            Console.WriteLine("Load Eng UID :" + loadEngineer.GenerateId());
            */
            //Console.WriteLine();
            //DatabaseAccessObject dbAccessObject = new DatabaseAccessObject();
            //dbAccessObject.Update("DELETE FROM CUSTOMER;");
            //DataTable? dt = dbAccessObject.Retrieve("SELECT * FROM CUSTOMER;");
            //dbAccessObject.Update("DELETE FROM CUSTOMER;");
            //dbAccessObject.PrintDataTable(dt);
            //dt = dbAccessObject.Retrieve("SELECT * FROM CUSTOMER;");
            //dbAccessObject.PrintDataTable(dt);

            System. Console.WriteLine("\nThank you for playing Wing Commander\n");
        }
    }
}