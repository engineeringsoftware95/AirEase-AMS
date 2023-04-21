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
    public class FlightTests
    {
        [Test()]
        [TestCase("202315")]
        [TestCase("314242421")]
        [TestCase("")]

        public void FlightTest(string yearWeekId)
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();
            dao.Update("DELETE FROM FLIGHT;");
            Route route = new Route("Cleveland", "Atlanta", 150);
            route.UploadRoute();
            Flight flight = new Flight(route.GetRouteId(), "202314", DateTime.Now);
            flight.UploadFlight();

            Flight reused = new Flight(flight.GetFlightId(), flight.GetDepartureId());
            Assert.AreEqual(flight.GetDistance(), reused.GetDistance());
            Assert.Fail();
            dao.Update("DELETE FROM FLIGHT;");
        }

        [Test()]
        public void FlightTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void FlightTest2()
        {
            Assert.Fail();
        }

        [Test()]
        public void UploadFlightTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SetPlaneForFlightTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetDepartureIdTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetTimeTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void EqualsTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void EqualsTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetHashCodeTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void EstimateArrivalTimeTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetFlightIdTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetFlightCostTest()
        {
            Assert.Fail();
        }
    }
}