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
            DatabaseAccessObject dao = new DatabaseAccessObject();
            string query = "DELETE FROM AIRPORT;";
            dao.Update(query);
            Airport airport = new Airport(cityName, airportName);
            airport.UploadAirport();

            Airport reuse = new Airport(airport.GetAirportId());


            Assert.AreEqual(airport.GetCityName(), reuse.GetCityName());
            dao.Update(query);
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
            Assert.IsTrue(Convert.ToInt32(_testGuy.GetAirportId())>9999);
        }
    }
}