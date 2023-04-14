using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AirEase_AMS.App.Entity.User;
using System.Windows.Forms;

namespace Tests
{
    [TestFixture()]
    public class DatabaseAccessObjectTests
    {

        [Test()]
        [TestCase("", "", "", 0)]
        [TestCase("INSERT INTO CUSTOMER VALUES(123456, 'Password3', 'Ye', 'West', '677 Berry, Houston, TX', '6667778888', GETDATE(), 0.00, 0, '','');", "SELECT * FROM CUSTOMER;", "DELETE FROM CUSTOMER;", 1)]
        [TestCase("INSERT INTO CUSTOMER VALUES(123456, 'Password3', 'Ye', 'West', '677 Berry, Houston, TX', '6667778888', GETDATE(), 0.00, 0, '','');INSERT INTO CUSTOMER VALUES(123456, 'Password3', 'Ye', 'West', '677 Berry, Houston, TX', '6667778888', GETDATE(), 0.00, 0, '','');", "SELECT * FROM CUSTOMER;", "DELETE FROM CUSTOMER;", 1)]
        [TestCase("INSERT INTO CUSTOMER VALUES(654321, 'Password5', 'Booper', 'Dooper', '678 Sherry, Houston, TX', '123456789', GETDATE(), 0.00, 0, '','');INSERT INTO CUSTOMER VALUES(123456, 'Password3', 'Ye', 'West', '677 Berry, Houston, TX', '6667778888', GETDATE(), 0.00, 0, '','');", "SELECT * FROM CUSTOMER WHERE UserID = 123456;", "DELETE FROM CUSTOMER;", 1)]
        [TestCase("INSERT INTO AIRPORT VALUES(123456, 'Cleveland', 'Cleveland Hawkins');", "SELECT * FROM AIRPORT;", "DELETE FROM AIRPORT;", 1)]


        public void RetrieveTest(string insertQuery, string retrieveQuery, string deleteQuery, int expectedTableSize)
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();

            dao.Update(deleteQuery);

            Console.WriteLine(insertQuery);
            dao.Update(insertQuery);
            DataTable? dt = dao.Retrieve(retrieveQuery);

            //If delete wasn't working then the test case would pass but there would be a primary key violation (UNLESS we planned for there to be one for a specific test case... which we did.)
            dao.Update(deleteQuery);
            Assert.AreEqual(expectedTableSize, dt.Rows.Count);
        }


        //This is kind of a duplicate of RetrieveTest. If delete wasn't working then the test case would pass but there would be a primary key violation.
        [Test()]
        [TestCase("", "", 0)]
        [TestCase("INSERT INTO CUSTOMER VALUES(123456, 'Password5', 'Booper', 'Dooper', '678 Sherry, Houston, TX', '123456789', GETDATE(), 0.00, 0, '','');", "DELETE FROM CUSTOMER;", 1)]
        [TestCase("INSERT INTO CUSTOMER VALUES(654321, 'Password5', 'Booper', 'Dooper', '678 Sherry, Houston, TX', '123456789', GETDATE(), 0.00, 0, '','');INSERT INTO CUSTOMER VALUES(123456, 'Password3', 'Ye', 'West', '677 Berry, Houston, TX', '6667778888', GETDATE(), 0.00, 0, '','');", "DELETE FROM CUSTOMER;", 2)]
        [TestCase("INSERT INTO CUSTOMER VALUES(123456, 'Password5', 'Booper', 'Dooper', '678 Sherry, Houston, TX', '123456789', GETDATE(), 0.00, 0, '','');INSERT INTO CUSTOMER VALUES(123456, 'Password3', 'Ye', 'West', '677 Berry, Houston, TX', '6667778888', GETDATE(), 0.00, 0, '','');", "DELETE FROM CUSTOMER;", -1)]


        public void UpdateTest(string insertQuery, string deleteQuery, int expectedInsertCount)
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();

            int actualInsertCount = dao.Update(insertQuery);


            dao.Update(deleteQuery);
            Assert.AreEqual(expectedInsertCount, actualInsertCount);
        }
    }
}