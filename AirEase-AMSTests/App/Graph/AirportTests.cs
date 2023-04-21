using NUnit.Framework;
using AirEase_AMS.App.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirEase_AMS.App.Graph.Tests
{
    [TestFixture()]
    public class AirportTests
    {
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
        public void AirportTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void AirportTest2()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetAirportIdTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void UploadAirportTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void AddDepartureTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void ArrivingFlightsTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void DepartingFlightsTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SetCityTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetCityNameTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetRoutesTest()
        {
            Assert.Fail();
        }
    }
}