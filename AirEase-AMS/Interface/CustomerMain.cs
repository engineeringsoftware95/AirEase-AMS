using AirEase_AMS.App;
using AirEase_AMS.App.Entity.BoardingPass;
using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Graph;
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
            //foreach (Ticket tickets in return list of functions)
            //{

            //}

            InitializeComponent();

            // set combo boxes source to a list of all airports
            foreach (Airport city in HLib.SelectAllAirports())
            {
                comboBox2.Items.Add(city.GetCityName());
                comboBox3.Items.Add(city.GetCityName());
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoundTrip_CheckedChanged(object sender, EventArgs e)
        {

            label1.Visible = RoundTrip.Checked;
            dateTimePicker3.Visible = RoundTrip.Checked;
            comboBox4.Visible = RoundTrip.Checked;
            label3.Visible = RoundTrip.Checked;
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
                // do the thing to create two tickets then send to customer billing
            }
            else
            {
                // do the thing to create one ticket then send to customer billing

                //CustomerBilling customerBilling = new CustomerBilling(this, currentUser, comboBox3.Text, comboBox2.Text, dateTimePicker1.Value.ToString());
                this.Hide();
                //customerBilling.ShowDialog();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            // first clear table
            // get list of flights that match query
            // update table
            dataGridView4.Rows.Clear();
            // populate the rows with all of the flights that match the given parameters
            // allow selection of ticketID
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            listBox2.Items.Clear();
            foreach (Ticket ticket in currentUser.GetUpcomingTickets())
            {
                string info = ticket.GetTicketId();
                foreach (Flight flight in ticket.GetFlights())
                {
                    
                }
            }

            // update upcoming flights
            comboBox5.Items.Clear();
            listBox1.Items.Clear();
            foreach (Ticket ticket in currentUser.GetUpcomingTickets())
            {
                comboBox5.Items.Add(ticket.GetTicketId());
                listBox1.Items.Add(ticket.GetTicketInformation());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void Booking_Click(object sender, EventArgs e)
        {

        }

        private void BoardingPass_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedItem != null)
            {
                List<Flight> flights = new List<Flight>();
                foreach(Ticket ticket in currentUser.GetUpcomingTickets())
                {
                    foreach(Flight flight in ticket.GetFlights())
                    {
                        flights.Add(flight);
                    }
                }

                BoardingPass boarding = new BoardingPass(flights[comboBox3.SelectedIndex].GetFlightId(), );
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
