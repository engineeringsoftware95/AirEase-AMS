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
            Console.WriteLine();
            DatabaseAccessObject dbAccessObject = new DatabaseAccessObject();
            dbAccessObject.Update("DELETE FROM CUSTOMER;");
            DataTable? dt = dbAccessObject.Retrieve("SELECT * FROM CUSTOMER;");
            dbAccessObject.Update("DELETE FROM CUSTOMER;");
            dbAccessObject.PrintDataTable(dt);
            dt = dbAccessObject.Retrieve("SELECT * FROM CUSTOMER;");
            dbAccessObject.PrintDataTable(dt);

            //!This is actually important for testing, you can comment it out but do not delete it please. Maybe someday it'll be its own function.
            /*Accountant ac = new Accountant("Tabitha", "Taberton", "123 Tabby Street, Dallas, TX", "2023-04-14", "Password123", "2223339999", "tabbers@accountant.net", "123456789");
            Console.WriteLine(ac.AttemptAccountCreation());
            FlightManager fm = new FlightManager("Robert", "Robertson", "123 Robby Road, Dallas, TX", "2023-04-14", "Password123", "2223339999", "robbs@flightmanager.rob", "143456789");
            Console.WriteLine(fm.AttemptAccountCreation());
            LoadEngineer le = new LoadEngineer("Shelby", "Shelton", "123 Engineer Street, Dallas, TX", "2023-04-14", "Password123", "2223339999", "sHlb@loadeng.net", "323456789");
            Console.WriteLine(le.AttemptAccountCreation());
            MarketManager mm = new MarketManager("Patricia", "Pattinson", "123 Market Road, Dallas, TX", "2023-04-14", "Password123", "2223339999", "patsy@marketmanager.net", "123456789");
            Console.WriteLine(mm.AttemptAccountCreation());
            */
            Console.WriteLine("Thank you for playing Wing Commander");


        }
    }
}