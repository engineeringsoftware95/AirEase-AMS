
﻿using NUnit.Framework;
using AirEase_AMS.App.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirEase_AMS.App.Graph.Flight;
using AirEase_AMS.App.Graph;
using AirEase_AMS.App.Entity.User;

namespace AirEase_AMS.App.Ticket.Tests
{
    [TestFixture()]
    public class FlightManifestTests
    {
        [Test()]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(10)]
        [TestCase(100)]
        [TestCase(250)]

        public void FlightManifestTest(int numCustomersPerFlight)
        {
            HLib.NuclearRedButton();


            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 230);
            defaultAircraft.SetAircraftId("111111");
            if(!defaultAircraft.UploadAircraft()) Assert.Fail();




            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            if(!origin.UploadAirport()) Assert.Fail();

            Airport destination = new Airport("New York", "LaGuardia");
            if (!destination.UploadAirport()) Assert.Fail();

            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 150);
            if(!route.UploadRoute()) Assert.Fail();

            DateTime time = DateTime.Now.AddDays(25);
            string yearWeekId = time.Year.ToString();
            yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();

            Flight flight1 = new Flight(route.GetRouteId(), yearWeekId, DateTime.Now.AddDays(25));
            if (!flight1.UploadFlight()) Assert.Fail();

            time = DateTime.Now.AddMonths(1);
            yearWeekId = time.Year.ToString();
            yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();

            Flight flight2 = new Flight(route.GetRouteId(), yearWeekId, DateTime.Now.AddMonths(1));
            if (!flight2.UploadFlight()) Assert.Fail();

            time = DateTime.Now.AddDays(9);
            yearWeekId = time.Year.ToString();
            yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();

            Flight flight3 = new Flight(route.GetRouteId(), yearWeekId, DateTime.Now.AddDays(9));
            if (!flight3.UploadFlight()) Assert.Fail();

            for(int i = 0; i < numCustomersPerFlight - 5; i++)
            {
                Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
                customer.AttemptAccountCreation();
                Ticket ticket = new Ticket("Cleveland", "Tennessee", customer.GetUserId().ToString(), false);
                ticket.AddFlight(flight1);
                if (!ticket.UploadTicket()) Assert.Fail();
            }

            for (int i = 0; i < numCustomersPerFlight; i++)
            {
                Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
                customer.AttemptAccountCreation();
                Ticket ticket = new Ticket("Cleveland", "Tennessee", customer.GetUserId().ToString(), false);
                ticket.AddFlight(flight2);
                if (!ticket.UploadTicket()) Assert.Fail();
            }
            for (int i = 0; i < numCustomersPerFlight + 5; i++)
            {
                Customer customer = new Customer("Bob", "Bob", "Testaddress", DateTime.Now.ToString(), "Password123", "2223334444", "bob@bob.bob");
                customer.AttemptAccountCreation();
                Ticket ticket = new Ticket("Cleveland", "Tennessee", customer.GetUserId().ToString(), false);
                ticket.AddFlight(flight3);
                if (!ticket.UploadTicket()) Assert.Fail();
            }


            FlightManifest manifest1 = new FlightManifest(flight1.GetFlightId(), flight1.GetDepartureId());
            Assert.AreEqual(numCustomersPerFlight - 5, manifest1.PassengersOnFlightCount());

            FlightManifest manifest2 = new FlightManifest(flight2.GetFlightId(), flight2.GetDepartureId());
            Assert.AreEqual(numCustomersPerFlight, manifest2.PassengersOnFlightCount());


            FlightManifest manifest3 = new FlightManifest(flight3.GetFlightId(), flight3.GetDepartureId());
            Assert.AreEqual(numCustomersPerFlight+5, manifest3.PassengersOnFlightCount());

            HLib.NuclearRedButton();
        }
    }

}