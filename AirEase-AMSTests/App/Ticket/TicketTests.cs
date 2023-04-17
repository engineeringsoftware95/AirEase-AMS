using NUnit.Framework;
using AirEase_AMS.App.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirEase_AMS.App.Ticket.Tests
{
    [TestFixture()]
    public class TicketTests
    {
        [Test()]
        [TestCase(87.0, "Cleveland", "Tennessee")]
        [TestCase(182.20, "Cleveland", "Tennessee")]
        [TestCase(87.95, "Cleveland", "Tennessee")]
        [TestCase(1.0, "Cleveland", "Tennessee")]
        [TestCase(0.0, "Cleveland", "Tennessee")]
        public void TicketTest(decimal ticketCost, string startCity, string endCity)
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();
            dao.Update("DELETE FROM TICKETS;");
            Ticket ticket = new Ticket(ticketCost, startCity, endCity);
            ticket.PurchaseTicket();

            Ticket reused = new Ticket(ticket.GetTicketId());
            Assert.AreEqual(ticket.GetTicketCost(), reused.GetTicketCost());
            dao.Update("DELETE FROM TICKETS;");
        }
    }
}