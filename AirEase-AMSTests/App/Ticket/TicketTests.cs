using NUnit.Framework;
using AirEase_AMS.App.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Graph.Flight;
using AirEase_AMS.App.Graph;

namespace AirEase_AMS.App.Ticket.Tests
{
    [TestFixture()]
    public class TicketTests
    {
        [Test()]
        [TestCase(87.0, "Cleveland", "Tennessee", 0, false)]
        [TestCase(182.20, "Cleveland", "Tennessee", 1, true)]
        [TestCase(87.95, "Cleveland", "Tennessee", 2, true)]
        [TestCase(1.0, "Cleveland", "Tennessee", 3, true)]
        [TestCase(0.0, "Cleveland", "Tennessee", 4, true)]
        public void TicketTest(decimal ticketCost, string startCity, string endCity, int numFlights, bool expect)
        {
            HLib.NuclearRedButton();

            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();

            DatabaseAccessObject dao = new DatabaseAccessObject();

            Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
            customer.AttemptAccountCreation();

            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            origin.UploadAirport();
            Airport destination = new Airport("New York", "LaGuardia");
            destination.UploadAirport();

            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 150);
            route.UploadRoute();

            Ticket ticket = new Ticket(ticketCost, startCity, endCity, customer.GetUserId().ToString(), false);
            for (int i = 0; i < numFlights; i++)
            {
                Flight flight = new Flight(route.GetRouteId(), "202314", DateTime.Now);
                flight.UploadFlight();
                ticket.AddFlight(flight);
            }

            bool success = ticket.UploadTicket();
            Assert.AreEqual(expect, success);

            if (!expect) return;

            Ticket reused = new Ticket(ticket.GetTicketId());
            Assert.AreEqual(ticket.GetTicketCost(), reused.GetTicketCost());
            Assert.AreEqual(ticket.GetStraightLineMileage(), reused.GetStraightLineMileage());

            HLib.NuclearRedButton();
        }

        [Test()]
        [TestCase(57.06, true)]
        [TestCase(57.26, true)]
        [TestCase(1, true)]
        [TestCase(0, true)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(99.05, false)]
        [TestCase(199.37, false)]

        public void CancelTicketTest(decimal ticketCost, bool pointsUsed)
        {
            HLib.NuclearRedButton();

            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();

            DatabaseAccessObject dao = new DatabaseAccessObject();

            Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
            customer.AttemptAccountCreation();

            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            origin.UploadAirport();
            Airport destination = new Airport("New York", "LaGuardia");
            destination.UploadAirport();

            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 150);
            route.UploadRoute();

            Ticket ticket = new Ticket(ticketCost, "Cleveland", "New York", customer.GetUserId().ToString(), pointsUsed);
            for (int i = 0; i < 2; i++)
            {
                Flight flight = new Flight(route.GetRouteId(), "202314", DateTime.Now);
                flight.UploadFlight();
                ticket.AddFlight(flight);
            }

            bool success = ticket.UploadTicket();
            if (!success) Assert.Fail();

            bool cancelledSuccess = ticket.CancelTicket();
            Ticket reuse = new Ticket(ticket.GetTicketId());
            Assert.AreEqual(true, reuse.IsRefunded());

            Customer reuseCustomer = new Customer(customer.GetUserId().ToString(), customer.GetPassword());
            Assert.AreEqual(pointsUsed ? 0 : ticketCost, reuseCustomer._cashBalance);
            Assert.AreEqual(pointsUsed ? HLib.ConvertToPoints(ticketCost) : 0, reuseCustomer._pointBalance);

            HLib.NuclearRedButton();
        }

        [Test()]
        public void TicketTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void TicketTest2()
        {
            Assert.Fail();
        }

        [Test()]
        public void UploadTicketTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SetStraightLineMileageTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetStraightLineMileageTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetTicketCostTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetTicketIdTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void CalculateStraightLineMileageTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void CalculateTicketCostTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void AddFlightTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GenerateTicketIdTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetTicketInformationTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void PurchaseTicketTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void CancelTicketTest()
        {
            Assert.Fail();
        }
    }
}