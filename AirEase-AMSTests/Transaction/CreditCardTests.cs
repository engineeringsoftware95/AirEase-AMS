using NUnit.Framework;
using AirEase_AMS.App.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using AirEase_AMS.App.Entity.User;

namespace AirEase_AMS.App.Ticket.Tests
{
    [TestFixture()]
    public class CreditCardTests
    {
        [Test()]
        [TestCase("111222333444666", "420", "12121")]
        [TestCase("111222333444666", "420", "12121")]
        [TestCase("111222333444666", "420", "12121")]
        public void CreditCardTest(string ccNum, string cvc, string zip)
        {
            HLib.NuclearRedButton();

            Customer customer = new Customer("bob","bobby", "Bobby Road, TX",DateTime.Now.ToString(),"password123","2223334444","@.");
            customer.AttemptAccountCreation();
            CreditCard card = new CreditCard(ccNum, DateTime.Now.ToString(), cvc, zip, customer.GetUserId().ToString());
            card.SaveCreditCard();

            CreditCard reuse = new CreditCard(ccNum);

            Assert.AreEqual(card.GetCustomerId(), reuse.GetCustomerId());

            HLib.NuclearRedButton();
        }
    }
}