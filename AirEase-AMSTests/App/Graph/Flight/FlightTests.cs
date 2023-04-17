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
        public void FlightTest()
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();
            dao.Update("DELETE FROM FLIGHT;");
            //Flight flight = new Flight();

            //Flight reused = new Flight();
            //Assert.AreEqual(flight., reused.);
            Assert.Fail();
            dao.Update("DELETE FROM FLIGHT;");
        }
    }
}