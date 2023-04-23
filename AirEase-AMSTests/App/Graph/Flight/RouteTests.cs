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
    }
}