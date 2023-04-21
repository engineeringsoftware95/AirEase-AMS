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


            if (dt == null) Assert.Fail();

            Aircraft craft = new Aircraft(aircraft.GetAircraftId());

            Assert.AreEqual(craft.GetModelName(), aircraftName);
            dao.Update("DELETE FROM PLANE;");
        }

        [Test()]
        public void AircraftTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void AircraftTest2()
        {
            Assert.Fail();
        }

        [Test()]
        public void UploadAircraftTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SetAircraftIdTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SetCruisingSpeedTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SetModelNameTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SetFuelCapacityTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetCruisingSpeedTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetModelNameTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetNumberOfSeatsTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetFuelCapacityTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void CompareToTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetAircraftIdTest()
        {
            Assert.Fail();
        }
    }
}