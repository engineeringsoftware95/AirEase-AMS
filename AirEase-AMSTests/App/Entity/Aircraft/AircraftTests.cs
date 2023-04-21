using NUnit.Framework;
using AirEase_AMS.App.Entity.Aircraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace AirEase_AMS.App.Entity.Aircraft.Tests
{
    [TestFixture()]
    public class AircraftTests
    {

        private Aircraft _testman;

        [SetUp]
        public void SetUp()
        {
            _testman = new Aircraft();
        }
        
        
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
        public void UploadAircraftTest()
        {
            Assert.Fail();
        }

        [Test()]
        [TestCase("Airplany McAirplaneface")]
        [TestCase("Crudbump")]
        [TestCase("NotOnFire")]
        public void AircraftIdTest(string id)
        {
           _testman.SetAircraftId(id);
            Assert.AreEqual(id, _testman.GetAircraftId());
        }

        [Test()]
        [TestCase(0)]
        [TestCase(5000)]
        [TestCase(10)]
        public void CruisingSpeedTest(int speed)
        {
            _testman.SetCruisingSpeed(speed);

            Assert.AreEqual(_testman.GetCruisingSpeed(), speed);
        }
        
        [Test()]
        [TestCase(0)]
        [TestCase(5000)]
        [TestCase(10)]
        public void SeatsTest(int seats)
        {
            _testman.SetNumberOfSeats(seats);

            Assert.AreEqual(_testman.GetNumberOfSeats(), seats);
        }

        [Test()]
        [TestCase("Airplany McAirplaneface")]
        [TestCase("Crudbump")]
        [TestCase("NotOnFire")]
        public void ModelNameTest(string name)
        {
            _testman.SetModelName(name);
            Assert.AreEqual(name, _testman.GetModelName());
        }

        [Test()]
        [TestCase(0)]
        [TestCase(5000)]
        [TestCase(10)]
        public void FuelCapacityTest(int cap)
        {
            _testman.SetFuelCapacity(cap);
            Assert.AreEqual(cap, _testman.GetFuelCapacity());
        }

        [Test()]
        public void CompareToSelfTest()
        {
            Aircraft mang = _testman;
            Assert.AreEqual(mang.CompareTo(_testman), 0);
        }
        [Test()]
        public void CompareToNull()
        {
            
            Assert.AreEqual(_testman.CompareTo(null), 1);
        }

        [Test()]
        [TestCase("Airplany McAirplaneface", "Hellscape")]
        [TestCase("Crudbump", "Not Me")]
        [TestCase("NotOnFire", "On Fire")]
        public void CompareNames(string testname, string new_name)
        {
            Aircraft mang = new Aircraft();
            mang.SetModelName(testname);
            _testman.SetModelName(new_name);
            Assert.IsFalse(_testman.CompareTo(mang)==0);
        }
    }
}