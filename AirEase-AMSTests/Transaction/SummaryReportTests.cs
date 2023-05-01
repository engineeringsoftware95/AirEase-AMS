using NUnit.Framework;
using AirEase_AMS.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirEase_AMS.App.Graph.Flight;
using AirEase_AMS.App.Graph;
using AirEase_AMS.App;
using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Ticket;

namespace AirEase_AMS.Transaction.Tests
{
    [TestFixture()]
    public class SummaryReportTests
    {
        [Test()]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(25, 0)]
        [TestCase(0, 25)]
        [TestCase(100, 175)]
        public void SummaryReportTest(int numTransactions, int numFlights)
        {
            HLib.NuclearRedButton();

            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();


            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            origin.UploadAirport();

            Airport destination = new Airport("New York", "LaGuardia");
            destination.UploadAirport();

            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 150);
            route.UploadRoute();

            if (numFlights == 0) numTransactions = 0;

            for(int i = 0; i < numFlights; i++)
            {
                DateTime time = DateTime.Now.AddDays(9);
                string yearWeekId = time.Year.ToString();
                yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();
                Flight flight = new Flight(route.GetRouteId(), yearWeekId, time);
                flight.UploadFlight();

                for (int j = 0; j < numTransactions; j++)
                {
                    Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
                    customer.AttemptAccountCreation();
                    Ticket ticket = new Ticket("Cleveland", "Tennessee", customer.GetUserId().ToString(), false);
                    ticket.AddFlight(flight);
                    if (!ticket.UploadTicket()) Assert.Fail();
                }
            }

            SummaryReport report = new SummaryReport();

            Assert.AreEqual(numFlights, report.GetNumberOfFlights());
            Assert.AreEqual(numTransactions*numFlights, report.GetNumberOfTransactions());

            HLib.NuclearRedButton();
        }
    }
}