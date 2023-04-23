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

            Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(),"Password123", "2223334444", "bob@bob.bob");
            customer.AttemptAccountCreation();

            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            origin.UploadAirport();
            Airport destination = new Airport("New York", "LaGuardia");
            destination.UploadAirport();

            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 150);
            route.UploadRoute();

            Ticket ticket = new Ticket(ticketCost, startCity, endCity, customer.GetUserId().ToString());
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

            HLib.NuclearRedButton();
        }
    }
}