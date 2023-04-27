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
        private List<Flight> flights;
        private List<Ticket> tickets;

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

            }
            else if (CustomerTabControl.SelectedTab.Equals(Booking))
            {
                // update the table containing all bookable flights

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Equals(PastFlights))
            {
                // update news feed and upcoming departure list
            }
            else if (tabControl1.SelectedTab.Equals(CanceledFlights))
            {
                // update flights with canceled flights

            }
        }

        private void AccountHistory_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Booking_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button1 books the currently selected flight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * set up the ticket object, query the database, find the departure time, check against current time
             * if within 48 hours, allow printing of boarding pass
             * if more than an hour before the flight, allow cancelation
             */
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

        }
    }
}
