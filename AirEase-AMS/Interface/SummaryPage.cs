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
        public SummaryPage(Customer loggedIn, Ticket ticket)
        {
            currentuser = loggedIn;
            purchasedTicket = ticket;
            InitializeComponent();
        }

        private void SummaryPage_Load(object sender, EventArgs e)
        {
            // show ticket(s) info under reciept, show current user info under account summary
            AccountSummary.Items.Add(currentuser.GetUserId() + "\n");
            AccountSummary.Items.Add(currentuser.GetFirstName() + "\n");
            AccountSummary.Items.Add(currentuser.GetLastName() + "\n");
            AccountSummary.Items.Add(currentuser.GetPhoneNum() + "\n");
            AccountSummary.Items.Add(currentuser.GetEmail() + "\n");

            Reciept.Items.Add(purchasedTicket.GetTicketInformation() + "\n");
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
