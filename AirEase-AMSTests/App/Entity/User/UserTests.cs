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
        [TestCase("John", "Smith", "smith@hotmail.com", "2223339999", "231 Jeffe, Jeff, JF", "2022-07-12", "Password22", 1)]
        [TestCase("", "", "", "", "", "", "", 0)]
        [TestCase("", "", "", "", "", "", "", 0)]
        [TestCase("John", "Smith", "smith@hotmail.com", "2223339999", "231 Jeffe, Jeff, JF", "2022-07-12", "Password22", 1)]


        public void AttemptAccountCreationTest(string firstName, string lastName, string email, string phoneNum, string address, string birthDate, string password, int expectedResult)
        {

            DatabaseAccessObject dao = new DatabaseAccessObject();

            //Ensure table is empty BEFORE making the insert, otherwise this test will be faulty.
            dao.Update("DELETE FROM CUSTOMER;");
            Customer customer = new Customer(firstName, lastName, address, birthDate, password, phoneNum, email);
            bool successful = customer.AttemptAccountCreation();
            Console.WriteLine("Was successful: " + successful);

            DataTable? dt = dao.Retrieve("SELECT * FROM CUSTOMER WHERE UserID=" + customer.GetUserId() + ";");

            dao.Update("DELETE FROM CUSTOMER;");
            Assert.AreEqual(expectedResult, dt.Rows.Count);
        }

        [Test()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void GenerateIdTest()
        {
            //This data is useless. Insert random garbage for the test.
            Customer cs = new Customer("Bob", "Bob", "test", "test", "2022-12-12", "test", "test");
            cs.GenerateId();
            Assert.AreEqual(6, cs.GetUserId().ToString().Length);
        }

        [Test()]
        [TestCase("John", "Smith", "smith@hotmail.com", "2223339999", "231 Jeffe, Jeff, JF", "2022-07-12", "Password22", true)]
        [TestCase("John", "Smith", "smith@hotmail.com", "2223339999", "231 Jeffe, Jeff, JF", "2022-07-12", "Password22", true)]
        [TestCase("", "", "", "", "", "", "", false)]
        public void AttemptLoginTest(string firstName, string lastName, string email, string phoneNum, string address, string birthDate, string password, bool expected)
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();

            //Ensure table is empty BEFORE making the insert, otherwise this test will be faulty.
            dao.Update("DELETE FROM CUSTOMER;");

            Customer customer = new Customer(firstName, lastName, address, birthDate, password, phoneNum, email);
            customer.AttemptAccountCreation();

            bool attempt = Customer.AttemptLogin(customer.GetUserId().ToString(), password);
            Assert.AreEqual(expected, attempt);

            dao.Update("DELETE FROM CUSTOMER;");
        }
    }
}