using NUnit.Framework;
using AirEase_AMS.App.Graph.Flight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using AirEase_AMS.App.Entity.Aircraft;

namespace AirEase_AMS.App.Graph.Flight.Tests
{
    [TestFixture()]
    public class FlightTests
    {
        [Test()]
        [TestCase()]
        [TestCase()]
        [TestCase()]

        public void FlightTest()
        {
            HLib.NuclearRedButton();

            DateTime time = DateTime.Now;
            string yearWeekId = time.Year.ToString();
            yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();

            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();


            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            origin.UploadAirport();

            Airport destination = new Airport("New York", "LaGuardia");
            destination.UploadAirport();

            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 150);
            route.UploadRoute();

            Flight flight = new Flight(route.GetRouteId(), yearWeekId, DateTime.Now);
            flight.UploadFlight();

            Flight reused = new Flight(flight.GetFlightId(), flight.GetDepartureId());

            Assert.AreEqual(flight.GetFlightId(), reused.GetFlightId());
            Assert.AreEqual(flight.GetDepartureId(), reused.GetDepartureId());
            Assert.AreEqual(flight.GetDistance(), reused.GetDistance());

            HLib.NuclearRedButton();
        }

        [Test()]
        public void SetPlaneForFlightTest()
        {
            HLib.NuclearRedButton();

            DateTime time = DateTime.Now;
            string yearWeekId = time.Year.ToString();
            yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();

            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();


            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            origin.UploadAirport();

            Airport destination = new Airport("New York", "LaGuardia");
            destination.UploadAirport();

            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 150);
            route.UploadRoute();

            Flight flight = new Flight(route.GetRouteId(), yearWeekId, DateTime.Now);
            flight.UploadFlight();

            Aircraft plane = new Aircraft("BOEING 737 MAX", 230);
            plane.UploadAircraft();
            flight.SetPlaneForFlight(plane.GetAircraftId());

            Flight reused = new Flight(flight.GetFlightId(), flight.GetDepartureId());
            Assert.AreEqual(plane.GetAircraftId(), reused.GetAircraftID());

            

            HLib.NuclearRedButton();
        }
    }
}