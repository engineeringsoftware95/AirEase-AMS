using AirEase_AMS.App;
using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Graph.Flight;
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
    public partial class CustomerBilling : Form
    {
        Form parent;
        Customer currentUser;
        Ticket ticketToBuy;
        Ticket ifRoundTrip;

        public CustomerBilling(Form calledFrom, Customer loggedIn, Ticket ticketOne)
        {
            parent = calledFrom;
            currentUser = loggedIn;
            ticketToBuy = ticketOne;
            ifRoundTrip = new Ticket();
            InitializeComponent();

            setUp();
        }

        public CustomerBilling(Form calledFrom, Customer loggedIn, Ticket ticketOne, Ticket ticketTwo)
        {
            parent = calledFrom;
            currentUser = loggedIn;
            ticketToBuy = ticketOne;
            ifRoundTrip = ticketTwo;
            InitializeComponent();

            setUp();
        }

        // handler for when this winform loads
        private void CustomerBilling_Load(object sender, EventArgs e)
        {
            flightInfo.Clear();
            flightInfo.Text = ticketToBuy.GetTicketInformation();

            setUp();
        }

        // handler for when the new payment button is clicked
        private void newPaymentMethod_Click(object sender, EventArgs e)
        {
            PaymentInformationEntry enter = new PaymentInformationEntry(currentUser, this);
            this.Hide();
            enter.ShowDialog();
        }

        // handler for when the purchase button is clicked
        private void purchase_Click(object sender, EventArgs e)
        {
            // buy the ticket
            ticketToBuy.UploadTicket();
            if (!string.IsNullOrEmpty(ifRoundTrip.GetOriginCity()))
            {
                ifRoundTrip.UploadTicket();
            }

            SummaryPage summary;
            if (!string.IsNullOrEmpty(ifRoundTrip.GetOriginCity()))
            {
                summary = new SummaryPage(parent, currentUser, ticketToBuy, ifRoundTrip);
            }
            else
            {
                summary = new SummaryPage(parent, currentUser, ticketToBuy);
            }
            this.Hide();
            summary.ShowDialog();
            this.Close();
        }

        // handler for when the text changes in the listbox called flightInfo (only listbox in this winform page)
        private void flightInfo_TextChanged(object sender, EventArgs e)
        {

        }

        // handler for when the cancel button is clicked
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Update();
            parent.Show();
            this.Close();
        }

        // handler for when the payment method dropdown box has a new thing selected
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // helper method to setup the information in the winform dropdown and list boxes
        public void setUp()
        {
            comboBox1.Items.Clear();

            CreditCard credit = new CreditCard(currentUser.GetUserId());

            comboBox1.Items.Add(credit.GetCCNum());
            if (HLib.ConvertToPoints((decimal)ticketToBuy.GetTicketCost()) < currentUser._pointBalance)
            {
                comboBox1.Items.Add("Points");
            }
        }
    }
}
