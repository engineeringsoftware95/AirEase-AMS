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
        Flight toPurchase;

        public CustomerMain(Customer loggedIn)
        {
            currentUser = loggedIn;
            InitializeComponent();
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
            this.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newPaymentMethod_Click(object sender, EventArgs e)
        {
            PaymentInformationEntry enter = new PaymentInformationEntry(currentUser, this);
            this.Hide();
            enter.ShowDialog();
        }

        private void bookingButton_Click(object sender, EventArgs e)
        {

            if (RoundTrip.Checked)
            {
                // do the thing to create two tickets...
            }
            else
            {
                // do the thing to create one ticket...

                CustomerBilling customerBilling = new CustomerBilling(this, currentUser, comboBox3.Text, comboBox2.Text, dateTimePicker1.Value.ToString());
                this.Hide();
                customerBilling.ShowDialog();
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            // query database for inputted info and display list of flights that meet parameters
            // first clear table
            // get list of flights that match query
            // update table
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void AccountHistory_Click(object sender, EventArgs e)
        {

        }

        private void UpcomingFlights_Click(object sender, EventArgs e)
        {

        }

        private void CustomerMain_Load(object sender, EventArgs e)
        {
            // update news feed and upcoming departure list
            NewsFeed.Items.Clear();
            NewsFeed.Items.Add("Air-Ease has been released!");

            upcomingDepartureList.Items.Clear();
            upcomingDepartureList.Items.Add(currentUser.GetUpcomingTickets());

            // update flights with past flights
            dataGridView2.DataSource = currentUser.GetPastTickets();

            // update upcoming flights
            dataGridView3.DataSource = currentUser.GetUpcomingTickets();

            // set combo boxes source to a list of all airports
            //comboBox3.DataSource = ;
            //comboBox2.DataSource = ;

            //have the user select a date and a time
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy    HH:mm";
            dateTimePicker3.CustomFormat = "MM/dd/yyyy    HH:mm";
        }
    }
}
