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

        private Ticket test_ticket;
        private DateTime _dateTime;
        
        
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
            Console.WriteLine(ticketCost.ToString());
            Console.WriteLine(pointsUsed);

            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();

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
            if (!success && !pointsUsed) Assert.Fail();
            if (!success && pointsUsed) Assert.Pass();

            bool cancelledSuccess = ticket.CancelTicket();
            Ticket reuse = new Ticket(ticket.GetTicketId());
            Assert.AreEqual(true, reuse.IsRefunded());

            Customer reuseCustomer = new Customer(customer.GetUserId().ToString());
            Assert.AreEqual(pointsUsed ? 0 : ticketCost, reuseCustomer._cashBalance);
            //Assert.AreEqual(pointsUsed ? HLib.ConvertToPoints(ticketCost) : 0, reuseCustomer._pointBalance);

            HLib.NuclearRedButton();
        }
        
        [Test()]
        [TestCase(0,   0,0,    ExpectedResult = 0)]
        [TestCase(150, 0,0,     ExpectedResult = 150)]
        [TestCase(150, 200, 0,    ExpectedResult = 350)]
        [TestCase(150, 200,100,  ExpectedResult = 450)]
        public double CalculateStraightLineMileageTest(int dist1, int dist2, int dist3)
        {
            Flight f1 = new Flight();
            Flight f2 = new Flight();
            Flight f3 = new Flight();
            f1.SetDistance(dist1);
            f2.SetDistance(dist2);
            f3.SetDistance(dist3);
            test_ticket = new Ticket();
            test_ticket.AddFlight(f1);
            test_ticket.AddFlight(f2);
            test_ticket.AddFlight(f3);


            return test_ticket.CalculateStraightLineMileage();
        }

        
        [Test()]
        [TestCase(0,   0, 0, ExpectedResult = 0)]
        [TestCase(200, 15, 1, ExpectedResult = 82)]
        [TestCase(300, 15, 2, ExpectedResult = 102)]
        [TestCase(300, 7, 2, ExpectedResult = 93.4)]
        [TestCase(300, 2, 2, ExpectedResult = 84.8)]
        [TestCase(800, 15, 3, ExpectedResult = 170)]
        public double CalculateTicketCostTest(int miles, int depart, int num_fights)
        {
            Airport origin = new Airport("FlavorTown", "FLVT");
            Airport dest = new Airport("New Jork", "La Quinta");
            Airport lyovr1 = new Airport("The west coast, but closer", "Del Taco");
            Airport lyovr2 = new Airport("a Pet Semetary, but for people", "Loboland");
            DateTime begin = new DateTime(2019, 1, 20, depart, 20, 40);
            
                 
            Flight flight = new Flight(origin, dest, begin);
            flight.SetDistance(miles);
            origin.AddDeparture(dest,flight);
            
            test_ticket = new Ticket();
            test_ticket.AddFlight(flight);
            for (int i = 1; i < num_fights; i++) 
            {
                test_ticket.AddFlight(new Flight());
            }

            return test_ticket.CalculateTicketCost();
        }
        

        [Test()]
        [TestCase(0, 0, "", 0, null, null, ExpectedResult = false)]
        [TestCase(1, 0, "", 0, null, null, ExpectedResult = true)]
        [TestCase(2, 0, "", 0, null, null, ExpectedResult = true)]
        [TestCase(3, 0, "", 0, null, null, ExpectedResult = true)]
        public bool GetTicketInformationTest(int num_flights,double cost, string ticketID, 
            int miles, Airport origin, Airport dest)
        {
            Flight f1 = new Flight();
            Flight f2 = new Flight();
            Flight f3 = new Flight();
            test_ticket = new Ticket();
            test_ticket.SetStraightLineMileage(miles);
            test_ticket.AddFlight(f1);
            test_ticket.AddFlight(f2);
            test_ticket.AddFlight(f3);
            string output = "";
            for (int i = 0; i < num_flights; i++)
            {
               output += test_ticket.GetTicketInformation();
            }

            return (output != "");
        }

    }
}