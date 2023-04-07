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
            DatabaseAccessObject dbAccessObject = new DatabaseAccessObject();
            dbAccessObject.Update("DELETE FROM CUSTOMER;");
            dbAccessObject.Update("INSERT INTO CUSTOMER\nVALUES(123456, 'Password3', 'Ye', 'West', '677 Berry, Houston, TX', '6667778888', GETDATE(), 0.00, 0);");
            DataTable? dt = dbAccessObject.Retrieve("SELECT * FROM CUSTOMER;");
            dbAccessObject.Update("DELETE FROM CUSTOMER;");
            dbAccessObject.PrintDataTable(dt);
            dt = dbAccessObject.Retrieve("SELECT * FROM CUSTOMER;");
            dbAccessObject.PrintDataTable(dt);

            Console.WriteLine("Thank you for playing Wing Commander");


        }
    }
}