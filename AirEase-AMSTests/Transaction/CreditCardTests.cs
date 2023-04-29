using NUnit.Framework;
using AirEase_AMS.App.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using AirEase_AMS.App.Entity.User;
using Microsoft.IdentityModel.Tokens;

namespace AirEase_AMS.App.Ticket.Tests
{
    [TestFixture()]
    public class CreditCardTests
    {
        [Test()]
        [TestCase("111222333444666", "420", "12121", true)]
        [TestCase("111222333444666", "420", "12121", true)]
        [TestCase("111222333444666", "420", "12121", true)]
        [TestCase("114666", "420", "12121", false)]
        [TestCase("111222333444abc", "420", "12121", false)]
        public void CreditCardTest(string ccNum, string cvc, string zip, bool expect)
        {
            HLib.NuclearRedButton();

            Customer customer = new Customer("bob","bobby", "Bobby Road, TX",DateTime.Now.ToString(),"password123","2223334444","@.");
            if (!customer.AttemptAccountCreation()) Assert.Fail();
            CreditCard card = new CreditCard(ccNum, DateTime.Now.AddDays(4).ToString(), cvc, zip, customer.GetUserId().ToString());
            bool actual = card.SaveCreditCard();
            if(!expect)
            {
                Assert.AreEqual(expect, actual);
                return;
            }
            else
            {
                CreditCard reuse = new CreditCard(ccNum);
                Assert.AreEqual(card.GetCustomerId(), reuse.GetCustomerId());
            }

            CreditCard card2 = new CreditCard(ccNum, DateTime.Now.AddDays(-1).ToString(), cvc, zip, customer.GetUserId().ToString());
            Assert.AreEqual("", card2.GetExpirationDate());
            CreditCard card3 = new CreditCard(customer.GetUserId());
            Assert.AreEqual(cvc, card3.GetCVC());
            Assert.AreEqual(ccNum, card3.GetCreditCardNum());
            HLib.NuclearRedButton();
        }
    }
}