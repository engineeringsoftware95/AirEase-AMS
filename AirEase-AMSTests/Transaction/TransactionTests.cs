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
        public void TransactionTest()
        {
            HLib.NuclearRedButton();

            Customer customer = new Customer("bob", "bobby", "Bobby Road, TX", DateTime.Now.ToString(), "password123", "2223334444", "@.");
            customer.AttemptAccountCreation();

            Transaction transaction = new Transaction(27.25m, customer.GetUserId().ToString());
            transaction.UploadTransaction();

            Transaction reused = new Transaction(transaction._transactionId);

            Assert.AreEqual(transaction._currencyCost, reused._currencyCost);
            Assert.AreEqual(transaction._pointCost, reused._pointCost);
            Assert.AreEqual(transaction._customerId, reused._customerId);
            Assert.AreEqual(transaction._transactionId, reused._transactionId);

            HLib.NuclearRedButton();
        }
    }
}