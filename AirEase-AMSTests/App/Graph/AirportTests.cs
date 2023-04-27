using NUnit.Framework;
using AirEase_AMS.App.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Graph.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace AirEase_AMS.App.Graph.Tests
{
    
    
    [TestFixture()]
    public class AirportTests
    {
        private Airport _testGuy;
        private IRoute testRoute;
        private Airport testAirport;
        private Flight.Flight testFlight = new Flight.Flight();

        [SetUp]
        public void SetUp()
        {
            _testGuy = new Airport(); 
            _testGuy.SetCity("Cleveland");
            testRoute = new Route();
            testAirport = new Airport();
            testAirport.SetCity("FlavorTown");
            testRoute.SetDestination(testAirport.GetCityName());
            testFlight = new Flight.Flight();
        }
        
        
        [Test()]
        [TestCase("Cleveland", "Cleveland Hawkins", ExpectedResult = false)]
        [TestCase("", "", ExpectedResult = true)]
        [TestCase("123", "osf2 sfs", ExpectedResult = false)]
        public bool AirportTest(string cityName, string airportName)
        {
          HLib.NuclearRedButton();
            Airport airport = new Airport(cityName, airportName);
            airport.UploadAirport();

            Airport reuse = new Airport(airport.GetAirportId());
            HLib.NuclearRedButton();
            return airport.GetCityName() ==  reuse.GetCityName();

        }
        
        [Test()]
        public void AddDepartureTest()
        {
            _testGuy.AddDeparture(testAirport, testRoute);
            Assert.IsTrue(_testGuy.DepartingFlights().Contains(testRoute));
        }


        [Test()]
        [TestCase("FlavorTown","flavortown", ExpectedResult = false)]
        [TestCase("FlavorTown","flavortown?", ExpectedResult = false)]
        [TestCase("FoodVille", "FlavorTown", ExpectedResult = true)] // valid
        public bool NodeTesting(string city, string dest)
        {
            _testGuy.SetCity(city);
            testRoute.SetOrigin(city);
            testRoute.SetDestination(dest);
            testFlight.SetDestination(dest);
            testFlight.SetOrigin(city);
            testRoute.AddFlight(testFlight);
            testAirport.SetCity("FlavorTown");
            _testGuy.AddDeparture(testAirport,testFlight);

            foreach (Flight.Flight flight in _testGuy.DepartingFlights())
            {
                if (flight.Destination().GetCityName() ==  testRoute.Destination().GetCityName())
                {
                    return true;
                }
            }
            return false;
        }


        [Test()]
        [TestCase("", "FlavorTown", "")]
        [TestCase("FlavorTown", "", "")] // null case
        [TestCase(5, "flavortown?", ""), ExpectedException( typeof(ArgumentException) )] // bad data
        public void NodeExceptionTesting(string city, string origin, string dest)
        {
            Flight.Flight testFlight = new Flight.Flight();
            testRoute = new Route();
            _testGuy.SetCity(city);
            testRoute.SetOrigin(origin);
            testRoute.SetDestination(dest);
            _testGuy.AddDeparture(new Airport(dest), testFlight);

          Assert.IsFalse(_testGuy.DepartingFlights().Contains(testRoute));
          
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
            Assert.IsTrue(Convert.ToInt32(_testGuy.GetAirportId())>9999);
        }
    }
}