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
        public void RouteTest()
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();
            dao.Update("DELETE FROM AIRPORT;");
            dao.Update("DELETE FROM FLIGHTROUTE;");
            Airport origin = new Airport("Cleveland", "Cleveland Hawkins");
            origin.UploadAirport();
            Airport destination = new Airport("New York", "LaGuardia");
            destination.UploadAirport();
            Route route = new Route(origin.GetAirportId(), destination.GetAirportId(), 160);
            route.UploadRoute();

            Route reuse = new Route(route.RouteId());


            Assert.AreEqual(route.GetDistance(), reuse.GetDistance());

            dao.Update("DELETE FROM FLIGHTROUTE;");
            dao.Update("DELETE FROM AIRPORT;");
        }
    }
}