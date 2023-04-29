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
        }

        public CustomerBilling(Form calledFrom, Customer loggedIn, Ticket ticketOne, Ticket ticketTwo)
        {
            parent = calledFrom;
            currentUser = loggedIn;
            ticketToBuy = ticketOne;
            ifRoundTrip = ticketTwo;
            InitializeComponent();
        }

        private void CustomerBilling_Load(object sender, EventArgs e)
        {
            flightInfo.Clear();
            flightInfo.Text = ticketToBuy.GetTicketInformation();

            comboBox1.Items.Clear();

            //if (currentUser._pointBalance > costInPoints)
            //{
            //    comboBox1.Items.Add(currentUser._pointBalance);
            //}
            //else
            //{
            //    if (currentUser._cashBalance < )    // ticket price
            //        comboBox1.Items.Add();          //add current users credit card number
            //    else
            //        comboBox1.Items.Add(currentUser._pointBalance);
            //}
        }

        private void newPaymentMethod_Click(object sender, EventArgs e)
        {
            PaymentInformationEntry enter = new PaymentInformationEntry(currentUser, this);
            this.Hide();
            enter.Show();
            // update payment methods list with new credit card if one has been entered
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            // buy the ticket
            ticketToBuy.UploadTicket();
            if (!string.IsNullOrEmpty(ifRoundTrip.GetOriginCity()))
            {
                ifRoundTrip.UploadTicket();
            }
            this.Hide();
            this.Close();
        }

        private void flightInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Update();
            parent.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
