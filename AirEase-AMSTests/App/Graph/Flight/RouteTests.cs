using NUnit.Framework;
using AirEase_AMS.App.Graph.Flight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirEase_AMS.App.Graph.Flight.Tests
{
    [TestFixture()]
    public class RouteTests
    {
        private Route ibilly;
        private Flight ijoseph;
        private DateTime begin;
        private DateTime end;

        [SetUp]
        public void SetUp()
        {
            ibilly = new Route();
            ibilly.SetOrigin("Flavor Town");
            ibilly.SetDestination("Flavor Town, but further away");
            ijoseph = new Flight();
            ibilly.AddFlight(ijoseph);
        }


            [Test()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void RouteTest()
        {
            HLib.NuclearRedButton();
            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            origin.UploadAirport();
            Airport destination = new Airport("New York", "LaGuardia");
            destination.UploadAirport();
            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 160);
            route.UploadRoute();

            Route reuse = new Route(route.GetRouteId());

            Assert.AreEqual(route.GetDistance(), reuse.GetDistance());
            Assert.AreEqual(route.GetRouteId(), reuse.GetRouteId());
            Assert.AreEqual(route.GetDistance(), reuse.GetDistance());

            HLib.NuclearRedButton();
        }

        [Test()]
        public void FlightExistsTest()
        {
           Assert.IsTrue(ibilly.FlightExists(ijoseph));
        }

        [Test()]
        public void FindFlightsInRangeTest()
        {
            List<Flight> testList = new List<Flight>();
            testList = ibilly.FindFlightsInRange(begin, end);

            Assert.AreEqual(testList[0], ijoseph);
        }
        
    }
}