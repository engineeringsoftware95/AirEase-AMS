using NUnit.Framework;
using AirEase_AMS.App.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Graph.Tests
{


    [TestFixture()]
    public class AirportTests
    {
        private Airport _testGuy;
        private IRoute testRoute;
        private Airport testAirport;

        [SetUp]
        public void SetUp()
        {
            _testGuy = new Airport();
            testRoute = new Route();
            testAirport = new Airport();
            testAirport.SetCity("FlavorTown");
            testRoute.SetDestination(testAirport.GetCityName());
        }




        [Test()]
        [TestCase("Cleveland", "Cleveland Hawkins")]
        [TestCase("", "")]
        [TestCase("123", "osf2 sfs")]
        public void AirportTest(string cityName, string airportName)
        {
            HLib.NuclearRedButton();
            Airport airport = new Airport(cityName, airportName);
            airport.UploadAirport();

            Airport reuse = new Airport(airport.GetAirportId());


            Assert.AreEqual(airport.GetCityName(), reuse.GetCityName());
            Assert.AreEqual(airport.GetAirportId(), reuse.GetAirportId());

            HLib.NuclearRedButton();
        }


        [Test()]
        public void UploadAirportTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void AddDepartureTest()
        {
            _testGuy.AddDeparture(testAirport, testRoute);
            Assert.IsTrue(_testGuy.DepartingFlights().Contains(testRoute));
        }
        [Test()]
        public void AirportIdTest()
        {
            _testGuy.SetCity("FlavorTown");
            Assert.AreEqual(_testGuy.GetCityName(), "FlavorTown");
        }

        [Test()]
        public void GetCityNameTest()
        {
            _testGuy.SetCity("FlavorTown");
            Assert.IsTrue(Convert.ToInt32(_testGuy.GetAirportId()) > 9999);
        }

        [Test()]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(10)]
        public void PopulateEdgesTest(int numRoutes)
        {
            HLib.NuclearRedButton();
            //This should be a good baseline
            Airport tennessee = new Airport("Nashville", "Nashville International Aiport");
            if (!tennessee.UploadAirport()) Assert.Fail();
            Airport cleveland = new Airport("Cleveland", "Cleveland Hopkins International Airport");
            if (!cleveland.UploadAirport()) Assert.Fail();
            Airport washington = new Airport("Seattle", "Seattle-Tacoma International Aiport");
            if (!washington.UploadAirport()) Assert.Fail();
            Airport newyork = new Airport("New York", "LaGuardia International Airport");
            if (!newyork.UploadAirport()) Assert.Fail();

            for(int i = 0; i < numRoutes; i++) 
            {
                Route route1 = new Route(tennessee.GetAirportId(), washington.GetAirportId(), 150);
                route1.UploadRoute();
                Route route2 = new Route(cleveland.GetAirportId(), newyork.GetAirportId(), 150);
                route2.UploadRoute();
            }

            tennessee.PopulateEdges();
            Assert.AreEqual(numRoutes, tennessee.DepartingFlights().Count());
            washington.PopulateEdges();
            Assert.AreEqual(0, washington.DepartingFlights().Count());
            cleveland.PopulateEdges();
            Assert.AreEqual(numRoutes, cleveland.DepartingFlights().Count());
            newyork.PopulateEdges();
            Assert.AreEqual(0, newyork.DepartingFlights().Count());

            HLib.NuclearRedButton();
        }
    }
}