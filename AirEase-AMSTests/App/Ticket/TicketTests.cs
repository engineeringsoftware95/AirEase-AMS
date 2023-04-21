using NUnit.Framework;
using AirEase_AMS.App.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Ticket.Tests
{
    [TestFixture()]
    public class TicketTests
    {
        [Test()]
        [TestCase(87.0, "Cleveland", "Tennessee", 0)]
        [TestCase(182.20, "Cleveland", "Tennessee", 1)]
        [TestCase(87.95, "Cleveland", "Tennessee", 2)]
        [TestCase(1.0, "Cleveland", "Tennessee", 3)]
        [TestCase(0.0, "Cleveland", "Tennessee", 4)]
        public void TicketTest(decimal ticketCost, string startCity, string endCity, int numFlights)
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();




            Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
            customer.AttemptAccountCreation();




            Route route = new Route("Cleveland", "Atlanta", 150);
            route.UploadRoute();

            Ticket ticket = new Ticket(ticketCost, startCity, endCity, customer.GetUserId().ToString());
            for (int i = 0; i < numFlights; i++)
            {
                Flight flight = new Flight(route.GetRouteId(), "202314", DateTime.Now);
                flight.UploadFlight();
                ticket.AddFlight(flight);
            }

            ticket.PurchaseTicket();

            Ticket reused = new Ticket(ticket.GetTicketId());
            Assert.AreEqual(ticket.GetTicketCost(), reused.GetTicketCost());
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