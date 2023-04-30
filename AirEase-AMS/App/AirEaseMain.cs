using AirEase_AMS.App.Entity.Aircraft;
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


            HLib.NuclearRedButton();
            HLib.LoadDatabase();


            //DatabaseAccessObject dao = new DatabaseAccessObject(); 
            //Aircraft defaultAircraft = new Aircraft("B-52", 5);
            //defaultAircraft.SetAircraftId("111111");
            //defaultAircraft.UploadAircraft();

            //Console.WriteLine(HLib.SelectAllAircraft().ToArray()[0].GetModelName());

            //ApplicationConfiguration.Initialize();

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
            //dao.Update("DELETE FROM CUSTOMER;");
            //DataTable? dt = dao.Retrieve("SELECT * FROM CUSTOMER;");
            //dao.Update("DELETE FROM CUSTOMER;");
            //dao.PrintDataTable(dt);
            //dt = dao.Retrieve("SELECT * FROM CUSTOMER;");
            //dao.PrintDataTable(dt);
            //Customer c = new Customer("Bobby", "Bobber", "Testaddress", DateTime.Now.ToString(), "Test12", "1112223333", "bob@bob.bob");
            //Console.WriteLine(c.AttemptAccountCreation());

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
            //App.Ticket.Ticket tck = new App.Ticket.Ticket(76.22M, "Cleveland", "Atlanta", c.GetUserId().ToString());
            //Console.WriteLine(tck.GetTicketInformation());

            //Customer cs1 = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
            //cs1.AttemptAccountCreation();
            //Customer cs2 = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
            //cs2.AttemptAccountCreation();
            //Customer cs3 = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
            //cs3.AttemptAccountCreation();

            Console.WriteLine("\nThank you for playing Wing Commander\n");
        }
    }
}