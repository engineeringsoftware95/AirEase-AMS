using NUnit.Framework;
using AirEase_AMS.App.Entity.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Reflection.Metadata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace AirEase_AMS.App.Entity.User.Tests
{
    [TestFixture()]
    public class UserTests
    {
        [Test()]
        [TestCase("Bob", "Bob", "Testaddress", "Password123", "2223334444", "bob@bob.bob", 1)]
        [TestCase("", "", "", "", "", "", 0)]
        [TestCase("", "", "", "", "", "", 0)]
        [TestCase("Bob", "Bob", "Testaddress", "Password123", "2223334444", "bob@bob.bob", 1)]


        public void AttemptAccountCreationTest(string fName, string lName, string address, string password, string phoneNum, string email, int expected)
        {

            DatabaseAccessObject dao = new DatabaseAccessObject();

            //Ensure table is empty BEFORE making the insert, otherwise this test will be faulty.
            dao.Update("DELETE FROM CUSTOMER;");
            Customer customer = new Customer(fName, lName, address, DateTime.Now.ToString(), password, phoneNum, email);
            bool successful = customer.AttemptAccountCreation();
            Console.WriteLine("Was successful: " + successful);

            DataTable? dt = dao.Retrieve("SELECT * FROM CUSTOMER WHERE UserID=" + customer.GetUserId() + ";");

            dao.Update("DELETE FROM CUSTOMER;");
            Assert.AreEqual(expected, dt.Rows.Count);
        }

        [Test()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void GenerateIdTest()
        {
            //This data is useless. Insert random garbage for the test.
            Customer cs = new Customer("Bob", "Bob", "test", "test", DateTime.Now.ToString(), "test", "test");
            cs.GenerateId();
            Assert.AreEqual(6, cs.GetUserId().ToString().Length);
        }

        [Test()]
        [TestCase("Bob", "Bob", "Testaddress", "Password123", "2223334444", "bob@bob.bob", true)]
        [TestCase("Bob", "Bob", "Testaddress", "Password123", "2223334444", "bob@bob.bob", true)]
        [TestCase("", "", "", "", "", "", false)]
        public void AttemptLoginTest(string fName, string lName, string address, string password, string phoneNum, string email, bool expected)
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();

            //Ensure table is empty BEFORE making the insert, otherwise this test will be faulty.
            dao.Update("DELETE FROM CUSTOMER;");

            Customer customer = new Customer(fName, lName, address, DateTime.Now.ToString(), password, phoneNum, email);
            customer.AttemptAccountCreation();

            bool attempt = Customer.AttemptLogin(customer.GetUserId().ToString(), password);
            Assert.AreEqual(expected, attempt);

            dao.Update("DELETE FROM CUSTOMER;");
        }
    }
}