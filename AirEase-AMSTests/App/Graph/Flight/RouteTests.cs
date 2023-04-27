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


        [Test()]
        public void OriginTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void DestinationTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void IsDestinationTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void IsOriginTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetTimeTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetDistanceTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetRouteIdTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void CompareToTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void CompareByDistanceTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void RouteIdTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GenerateIdTest()
        {
            Assert.Fail();
        }

        [Test()]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(25)]

        public void PopulateFlightsOnRouteTest(int numFlights)
        {
            HLib.NuclearRedButton();

            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();


            //This should be a good baseline
            Airport tennessee = new Airport("Nashville", "Nashville International Aiport");
            if (!tennessee.UploadAirport()) Assert.Fail();
            Airport cleveland = new Airport("Cleveland", "Cleveland Hopkins International Airport");
            if (!cleveland.UploadAirport()) Assert.Fail();
            Airport washington = new Airport("Seattle", "Seattle-Tacoma International Aiport");
            if (!washington.UploadAirport()) Assert.Fail();
            Airport newyork = new Airport("New York", "LaGuardia International Airport");
            if (!newyork.UploadAirport()) Assert.Fail();

            Route route1 = new Route(tennessee.GetAirportId(), cleveland.GetAirportId(), 24);
            route1.UploadRoute();
            Route route2 = new Route(washington.GetAirportId(), cleveland.GetAirportId(), 24);
            route2.UploadRoute();
            Route route3 = new Route(tennessee.GetAirportId(), newyork.GetAirportId(), 24);
            route3.UploadRoute();
            Route route4 = new Route(washington.GetAirportId(), newyork.GetAirportId(), 24);
            route4.UploadRoute();


            for (int i = 0; i < numFlights;i++) 
            {
                Random rand = new Random();
                DateTime dateTime;
                //Sufficiently randomize the date and hours
                dateTime = DateTime.Now.AddMonths(rand.Next(0, 7)).AddDays(rand.Next(0, 27));
                dateTime.AddHours(rand.Next(0, 23)).AddMinutes(rand.Next(0, 59));
                Flight flight = new Flight(route1.GetRouteId(), HLib.GenerateYearWeekID(dateTime), dateTime);
                flight.UploadFlight();              
            }

            for (int i = 0; i < numFlights * 2; i++)
            {
                Random rand = new Random();
                DateTime dateTime;
                //Sufficiently randomize the date and hours
                dateTime = DateTime.Now.AddMonths(rand.Next(0, 7)).AddDays(rand.Next(0, 27));
                dateTime.AddHours(rand.Next(0, 23)).AddMinutes(rand.Next(0, 59));
                Flight flight = new Flight(route2.GetRouteId(), HLib.GenerateYearWeekID(dateTime), dateTime);
                flight.UploadFlight();
            }
            Assert.AreEqual(numFlights, route1.PopulateFlightsOnRoute());
            Assert.AreEqual(numFlights*2, route2.PopulateFlightsOnRoute());
            Assert.AreEqual(0, route3.PopulateFlightsOnRoute());

            HLib.NuclearRedButton();
        }

    }
}