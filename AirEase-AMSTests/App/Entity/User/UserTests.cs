using NUnit.Framework;
using AirEase_AMS.App.Entity.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Reflection.Metadata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using AirEase_AMS.App.Graph.Flight;
using AirEase_AMS.App.Ticket;
using AirEase_AMS.App.Graph;

namespace AirEase_AMS.App.Entity.User.Tests
{
    [TestFixture()]
    [SingleThreaded]
    public class UserTests
    {
        [Test()]
        [TestCase("Bob", "Bob", "Testaddress", "Password123", "2223334444", "bob@bob.bob", 1)]
        [TestCase("", "", "", "", "", "", 0)]
        [TestCase("", "", "", "", "", "", 0)]
        [TestCase("Bob", "Bob", "Testaddress", "Password123", "2223334444", "bob@bob.bob", 1)]


        public void AttemptAccountCreationTest(string fName, string lName, string address, string password, string phoneNum, string email, int expected)
        {
            HLib.NuclearRedButton();
            DatabaseAccessObject dao = new DatabaseAccessObject();

            Customer customer = new Customer(fName, lName, address, DateTime.Now.ToString(), password, phoneNum, email);
            bool successful = customer.AttemptAccountCreation();

            DataTable? dt = dao.Retrieve("SELECT * FROM CUSTOMER WHERE UserID=" + customer.GetUserId() + ";");

            Assert.AreEqual(expected, dt.Rows.Count);
            HLib.NuclearRedButton();
        }

        [Test()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void GenerateIdTest()
        {
            //This data is useless. Insert random garbage for the test.
            Customer cs = new Customer("Bob", "Bob", "test", "test", DateTime.Now.ToString(), "test", "test");
            cs.GenerateId();
            Assert.AreEqual(6, cs.GetUserId().ToString().Length);
        }

        [Test()]
        [TestCase("Bob", "Bob", "Testaddress", "Password123", "2223334444", "bob@bob.bob", true)]
        [TestCase("Bob", "Bob", "Testaddress", "Password123", "2223334444", "bob@bob.bob", true)]
        [TestCase("", "", "", "", "", "", false)]
        public void AttemptLoginTest(string fName, string lName, string address, string password, string phoneNum, string email, bool expected)
        {
            HLib.NuclearRedButton();

            Customer customer = new Customer(fName, lName, address, DateTime.Now.ToString(), password, phoneNum, email);
            customer.AttemptAccountCreation();

            bool attempt = Customer.AttemptLogin(customer.GetUserId().ToString(), password);
            Assert.AreEqual(expected, attempt);
            if (!expected) return;

            //These should be identical
            Customer reuse = new Customer(customer.GetUserId().ToString());
            Assert.AreEqual(customer.GetLastName(), reuse.GetLastName());
            Assert.AreEqual(customer.GetFirstName(), reuse.GetFirstName());
            Assert.AreEqual(customer.GetUserId(), reuse.GetUserId());

            HLib.NuclearRedButton();
        }

        
        [Test()]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(9)]


        public void GetUpcomingTicketsTest(int numUpcoming)
        {
            {
                DatabaseAccessObject dao = new DatabaseAccessObject();

                //Delete absolutely everything -- dear god
                dao.Update("EXEC DeleteAllRecords;");
            }


            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();

            DateTime time = DateTime.Now;
            string yearWeekId = time.Year.ToString();
            yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();

            Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
            if(!customer.AttemptAccountCreation()) Assert.Fail();

            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            origin.UploadAirport();
            Airport destination = new Airport("New York", "LaGuardia");
            destination.UploadAirport();

            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 160);
            route.UploadRoute();

            for(int i = -5; i <= numUpcoming; i++)
            {
                Ticket.Ticket ticket = new Ticket.Ticket(100, "Cleveland", "Atlanta", customer.GetUserId().ToString(), false);
                Flight flight = new Flight(route.GetRouteId(), (int.Parse(yearWeekId) + i).ToString(), DateTime.Now);
                flight.UploadFlight();
                ticket.AddFlight(flight);
                Flight flight2 = new Flight(route.GetRouteId(), (int.Parse(yearWeekId) + i).ToString(), DateTime.Now);
                flight2.UploadFlight();
                ticket.AddFlight(flight2);
                ticket.UploadTicket();
            }


            Assert.AreEqual(numUpcoming, customer.GetUpcomingTickets().Count);

            {
                DatabaseAccessObject dao = new DatabaseAccessObject();

                //Delete absolutely everything -- dear god
                dao.Update("EXEC DeleteAllRecords;");
            }
        }

        [Test()]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(9)]

        public void GetPastTicketsTest(int numPastTickets)
        {
            HLib.NuclearRedButton();

            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();

            DateTime time = DateTime.Now;
            string yearWeekId = time.Year.ToString();
            yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();

            Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
            if (!customer.AttemptAccountCreation()) Assert.Fail();

            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            if(!origin.UploadAirport()) Assert.Fail();
            Airport destination = new Airport("New York", "LaGuardia");
            if(!destination.UploadAirport()) Assert.Fail();
            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 160);
            if(!route.UploadRoute()) Assert.Fail();
            
            for (int i = numPastTickets*-1; i < 5; i++)
            {
                Ticket.Ticket ticket = new Ticket.Ticket(100, "Cleveland", "Atlanta", customer.GetUserId().ToString(), false);
                Flight flight = new Flight(route.GetRouteId(), (int.Parse(yearWeekId) + i).ToString(), DateTime.Now);
                if(!flight.UploadFlight())Assert.Fail();
                ticket.AddFlight(flight);
                Flight flight2 = new Flight(route.GetRouteId(), (int.Parse(yearWeekId) + i).ToString(), DateTime.Now);
                if(!flight2.UploadFlight())Assert.Fail();
                ticket.AddFlight(flight);
                if(!ticket.UploadTicket())Assert.Fail();
            }
            
            Assert.AreEqual(Math.Abs(numPastTickets), customer.GetPastTickets().Count);

            HLib.NuclearRedButton();
        }
        
    }
}