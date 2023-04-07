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
        [TestCase("INSERT INTO CUSTOMER\nVALUES(123456, 'Password3', 'Ye', 'West', '677 Berry, Houston, TX', '6667778888', GETDATE(), 0.00, 0);", "SELECT * FROM CUSTOMER;")]
        public void RetrieveTest(string insertQuery, string retrieveQuery)
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();

            dao.Update(insertQuery);
            DataTable? dt = dao.Retrieve(retrieveQuery);

            Assert.AreEqual(dt.Rows.Count, 1);
        }
    }
}