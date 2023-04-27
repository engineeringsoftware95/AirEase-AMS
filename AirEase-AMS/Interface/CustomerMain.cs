using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Graph.Flight;
using AirEase_AMS.App.Ticket;
using Microsoft.IdentityModel.Abstractions;
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
    public partial class CustomerMain : Form
    {
        Customer currentUser;

        public CustomerMain(Customer loggedIn)
        {
            currentUser = loggedIn;
            InitializeComponent();
        }

        private void CustomerTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerTabControl.SelectedTab.Equals(Home))
            {
                // update news feed and upcoming departure list

            }
            else if (CustomerTabControl.SelectedTab.Equals(AccountHistory))
            {
                // update flights with past flights
                dataGridView2.DataSource = currentUser.GetPastTickets();
            }
            else if (CustomerTabControl.SelectedTab.Equals(UpcomingFlights))
            {
                // update upcoming flights
                dataGridView3.DataSource = currentUser.GetUpcomingTickets();

            }
            else if (CustomerTabControl.SelectedTab.Equals(Booking))
            {
                // update the table containing all bookable flights

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (RoundTrip.Checked)
            {
                label1.Visible = true;
                dateTimePicker3.Visible = true;
            }
            else
            {
                label1.Visible = false;
                dateTimePicker3.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newPaymentMethod_Click(object sender, EventArgs e)
        {
            PaymentInformationEntry enter = new PaymentInformationEntry(currentUser, this);
            this.Hide();
            enter.Show();
        }

        private void bookingButton_Click(object sender, EventArgs e)
        {

            if (RoundTrip.Checked)
            {

            }
            else
            {

            }
            //CustomerBilling customerBilling = new CustomerBilling(currentUser, comboBox3.Text, comboBox2.Text, dateTimePicker1.Value.ToString);
            //customerBilling.Show();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string flights = dataGridView4.SelectedRows.ToString();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            // query database for inputted info and display list of flights that meet parameters
            // first clear table
            // get list of flights that match query
            // update table
        }
    }
}
