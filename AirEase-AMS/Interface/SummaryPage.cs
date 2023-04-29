using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Ticket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirEase_AMS.Interface
{
    public partial class SummaryPage : Form
    {
        Customer currentuser;
        Ticket purchasedTicket;
        Ticket returnTicket;

        public SummaryPage(Customer loggedIn, Ticket ticket)
        {
            currentuser = loggedIn;
            purchasedTicket = ticket;
            returnTicket = new Ticket();
            InitializeComponent();
        }
        public SummaryPage(Customer loggedIn, Ticket ticket, Ticket secondTicket)
        {
            currentuser = loggedIn;
            purchasedTicket = ticket;
            returnTicket = secondTicket;
            InitializeComponent();
        }

        private void SummaryPage_Load(object sender, EventArgs e)
        {
            // show ticket(s) info under reciept, show current user info under account summary
            AccountSummary.Items.Add(currentuser.GetUserId());
            AccountSummary.Items.Add(currentuser.GetFirstName());
            AccountSummary.Items.Add(currentuser.GetLastName());
            AccountSummary.Items.Add(currentuser.GetPhoneNum());
            AccountSummary.Items.Add(currentuser.GetEmail());
            CreditCard creditCard = new CreditCard(currentuser.GetUserId().ToString());
            AccountSummary.Items.Add(creditCard.GetCCNum());
            AccountSummary.Items.Add(creditCard.GetExpirationDate());

            Reciept.Items.Add(purchasedTicket.GetTicketInformation());
            if(!string.IsNullOrEmpty(returnTicket.GetOriginCity()))
            {
                Reciept.Items.Add(" ");
                Reciept.Items.Add(returnTicket.GetTicketInformation());
            }
        }

        private void confirmationButton_Click(object sender, EventArgs e)
        {
            CustomerMain customerInstance = new CustomerMain(currentuser);
            this.Hide();
            customerInstance.ShowDialog();
        }

        private void AccountSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
