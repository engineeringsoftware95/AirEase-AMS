using NUnit.Framework;
using AirEase_AMS.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Ticket;
using AirEase_AMS.App;
using AirEase_AMS.App.Graph.Flight;
using AirEase_AMS.App.Graph;

namespace AirEase_AMS.Transaction.Tests
{
    [TestFixture()]
    public class TransactionTests
    {
        [Test()]
        [TestCase(27.25, 0)]
        [TestCase(0, 2725)]
        [TestCase(2, 0)]
        [TestCase(0, 3)]
        [TestCase(3, 3)]
        public void TransactionTest(decimal currency, int points)
        {
            bool expected = true;
            if(currency > 0 && points > 0) { expected = false; }
            HLib.NuclearRedButton();

            Customer customer = new Customer("bob", "bobby", "Bobby Road, TX", DateTime.Now.ToString(), "password123", "2223334444", "@.");
            customer.AttemptAccountCreation();

            Transaction transaction = new Transaction(currency, points, customer.GetUserId().ToString());
            bool actual = transaction.UploadTransaction();
            if(!actual && !expected) Assert.Pass();
            else if(!actual && expected) Assert.Fail();

            Transaction reused = new Transaction(transaction.GetTransactionId());

            Assert.AreEqual(transaction._currencyCost, reused._currencyCost);
            Assert.AreEqual(transaction._pointCost, reused._pointCost);
            Assert.AreEqual(transaction._customerId, reused._customerId);
            Assert.AreEqual(transaction.GetTransactionId(), reused.GetTransactionId());

            HLib.NuclearRedButton();
        }
    }
}