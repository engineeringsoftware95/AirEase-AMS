using NUnit.Framework;
using AirEase_AMS.App.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Entity.Aircraft;
using AirEase_AMS.App.Graph.Flight;
using NUnit.Framework.Internal;


namespace AirEase_AMS.App.Graph.Tests
{


    [TestFixture()]
    public class GraphTests
    {
        private Graph graphTest;
        private IRoute testRoute;
        private IRoute? otherRoute;
        private Airport testOrigin;
        private Airport testDestination;
        private List<Flight.Flight> testList;
        private DateTime begin;
        private Flight.Flight testFlight;
        private DateTime end;
        [SetUp]
        public void SetUp()
        {
            graphTest = new Graph();
            otherRoute = new Route();
            testRoute = new Route();
            testOrigin = new Airport();
            testDestination = new Airport();
            testList = new List<Flight.Flight>();
            testOrigin.SetCity("FlavorTown");
            testDestination.SetCity("New Jersey, but in Brazil");
            DateTime begin = new DateTime();
            testRoute.SetOrigin(testOrigin.GetCityName());
            testRoute.SetDestination(testDestination.GetCityName());
            testFlight = new Flight.Flight(testOrigin, testDestination, begin);
            testRoute.AddFlight(testFlight); 
            end = new DateTime();
            testOrigin.AddDeparture(testDestination, testRoute);
            
            graphTest.add_node(testOrigin);
            graphTest.add_node(testDestination);
        }
        [Test()]
        public void FindFlightTest()
        {
           otherRoute = graphTest.FindFlight("FlavorTown", "New Jersey, but in Brazil");
           Assert.AreSame(otherRoute, testRoute);
        }
 //       (string origin, string destination, DateTime begin,
  //          DateTime end)
        [Test()]
        public void GetFlightsInRangeTest()
        {
            begin = DateTime.Now;
            end = begin.AddMonths(6);
            testList = graphTest.GetFlightsInRange("FlavorTown", "New Jersey, but in Brazil", begin, end);
            Assert.IsTrue(testList.Contains(testFlight));
        }
    }
}