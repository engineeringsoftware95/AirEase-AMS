using NUnit.Framework;
using AirEase_AMS.App.Entity.Aircraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirEase_AMS.App.Entity.Aircraft.Tests
{
    [TestFixture()]
    public class AircraftTests
    {
        [Test()]
        [TestCase("Boeing 737", 150)]
        [TestCase("Boeing 737 MAX", 205)]
        [TestCase("Boeing 757", 175)]
        [TestCase("Boeing 767", 140)]
        [TestCase("Boeing 777", 230)]

        public void AircraftTest(string aircraftName, int numberOfSeats)
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();

            dao.Update("DELETE FROM PLANE;");
            Aircraft aircraft = new Aircraft(aircraftName, numberOfSeats);
            aircraft.UploadAircraft();
            string query = String.Format("SELECT * FROM PLANE WHERE PlaneID = {0}", aircraft.GetAircraftId());
            System.Data.DataTable dt = dao.Retrieve(query);


            if(dt == null) Assert.Fail();

            Aircraft craft = new Aircraft(aircraft.GetAircraftId());

            Assert.AreEqual(craft.GetModelName(), aircraftName);
            dao.Update("DELETE FROM PLANE;");
        }
    }
}