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
using AirEase_AMS.App.Defs;

namespace AirEase_AMS.Interface
{
    public partial class CustomerMain : Form
    {
        Customer currentUser;
        private Airport origin;
        private Airport dest;
        private Graph airportGraph;
        private List<Ticket> availableTickets;
        private DateTime selectedDeparture_OW;
        private DateTime selectedDeparture_RT;
        public CustomerMain(Customer loggedIn)
        {
            origin = new Airport();
            dest   = new Airport();
            airportGraph = new Graph();
            airportGraph.GraphInit();
            currentUser = loggedIn;
            
            //foreach (Ticket tickets in return list of functions)
            //{

            //}

            InitializeComponent();

            // set combo boxes source to a list of all airports
            foreach (Airport city in HLib.SelectAllAirports())
            {
                DestinationCityDropDown.Items.Add(city.GetCityName());
                OriginCityDropDown.Items.Add(city.GetCityName());
            }
        }
        // Dont care about this listbox handler
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // this will update the visibility of elements when the round trip check box is interacted with
        private void RoundTrip_CheckedChanged(object sender, EventArgs e)
        {

            label1.Visible = RoundTrip.Checked;
            DateTimePicker_RT.Visible = RoundTrip.Checked;
            comboBox4.Visible = RoundTrip.Checked;
            label3.Visible = RoundTrip.Checked;
            this.Update();
        }
        
        // do nothing when the label is clicked
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // this is the button on the home screen and opens up the new payment method window
        private void newPaymentMethod_Click(object sender, EventArgs e)
        {
            PaymentInformationEntry enter = new PaymentInformationEntry(currentUser, this);
            this.Hide();
            enter.ShowDialog();
        }

        // this is the handler for the book ticket button in the booking tab
        private void bookingButton_Click(object sender, EventArgs e)
        {

            if (RoundTrip.Checked)
            {
                // do the thing to create two tickets then send to customer billing
            }
            else
            {
                // do the thing to create one ticket then send to customer billing

                //CustomerBilling customerBilling = new CustomerBilling(this, currentUser, OriginCityDropDown.Text, DestinationCityDropDown.Text, DateTimePicker_OW.Value.ToString());
                Hide();
                //customerBilling.ShowDialog();
            }
        }

        // this is the handler for the search button in the customer booking tab
        private void Search_Click(object sender, EventArgs e)
        {
            availableTickets = new List<Ticket>();
            List<List<IRoute>> routesToDestination = airportGraph.FindRoutes(origin.GetCityName(), dest.GetCityName());
            
            foreach (List<IRoute> originToDestination in routesToDestination)
            {
                Console.Write(originToDestination.Count + " " + routesToDestination.Count + " "); Console.WriteLine("List of Route");
                Ticket t = new Ticket();
                foreach (IRoute route in originToDestination)
                {
                    Console.WriteLine("Route");
                    foreach (Flight flight in route.GetFlightsOnRoute())
                    {
                        Console.WriteLine("added "+route.Origin().GetCityName()+" to "+route.Destination().GetCityName());
                        t.SetStraightLineMileage(flight.GetDistance());
                        t.GenerateTicketId();
                        t.SetStartCity(route.Origin().GetCityName());
                        t.SetEndCity(route.Destination().GetCityName());
                        t.SetCost();
                        t.AddFlight(flight);
                        t.SetCustomerId(currentUser.GetUserId().ToString()); // how to get current customer ID?
                        t.IncrementFlightNum();
                    }
                }
                availableTickets.Add(t);
            }
            // first clear table
            // get list of flights that match query
            // update table
            selectedDeparture_OW = DateTimePicker_OW.Value.Date;
            if (RoundTrip.Checked)
            {
                selectedDeparture_RT = DateTimePicker_OW.Value.Date;
            } 
            // dataGridView4.Rows.Clear();
            // populate the rows with all of the flights that match the given parameters
            // allow selection of ticketID
        }

        // this is the handler for clicking the ticket cells in the list of tickets in the booking tab
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        // handler for when the home tab is clicked
        private void Home_Click(object sender, EventArgs e)
        {

        }

        // handler for when the account history tab is clicked
        private void AccountHistory_Click(object sender, EventArgs e)
        {

        }

        // handler for when the upcoming flights tab is clicked
        private void UpcomingFlights_Click(object sender, EventArgs e)
        {

        }

        // handler for when the winform loads
        private void CustomerMain_Load(object sender, EventArgs e)
        {
            // update news feed and upcoming departure list
            NewsFeed.Items.Clear();
            NewsFeed.Items.Add("Air-Ease has been released!");

            upcomingDepartureList.Items.Clear();
            upcomingDepartureList.Items.Add(currentUser.GetUpcomingTickets());

            // update flights with past flights
            listBox2.Items.Clear();
            listBox2.Items.Add("TicketID: Flight ID: Origin City, Destination City, Departure Time and Date");
            foreach (Ticket ticket in currentUser.GetUpcomingTickets())
            {
                foreach (Flight flight in ticket.GetFlights())
                {
                    string info = ticket.GetTicketId() + ": ";
                    info.Concat(flight.GetFlightId() + ": ");
                    info.Concat(flight.GetOriginCity() + ", ");
                    info.Concat(flight.GetDestinationCity() + ", ");
                    info.Concat(flight.GetTime().ToString());
                    listBox2.Items.Add(info);
                }
            }

            // update upcoming flights
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            listBox1.Items.Clear();
            foreach (Ticket ticket in currentUser.GetUpcomingTickets())
            {
                comboBox5.Items.Add(ticket.GetTicketId());
                listBox1.Items.Add(ticket.GetTicketInformation());
                foreach(Flight flight in ticket.GetFlights())
                {
                    comboBox6.Items.Add(flight.GetFlightId() + flight.GetDepartureId());
                }
            }
        }

        // handler for when the origin city dropdown box in the booking tab has a new item selected
        private void OriginCityDropDownBox_IndexChanged(object sender, EventArgs e)
        {
            origin = airportGraph.GetAirport(OriginCityDropDown.GetItemText(OriginCityDropDown.SelectedItem));
        }

        private void DestinationCityDropDownBox_IndexChanged(object sender, EventArgs e)
        {
            dest = airportGraph.GetAirport(DestinationCityDropDown.GetItemText(DestinationCityDropDown.SelectedItem));
        }

        // handler for when the value of datetime picker for the first ticket is changed
        private void DateTimePicker_OW_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void DateTimePicker_RT_ValueChanged(object sender, EventArgs e)
        {
            selectedDeparture_OW = DateTimePicker_OW.Value.Date;
        }

        // handler for the logout button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        // handler for when the button to book a flight is clicked
        private void Booking_Click(object sender, EventArgs e)
        {

        }

        // handler for when the button to print a boarding pass is clicked
        private void BoardingPass_Click(object sender, EventArgs e)
        {
            if (OriginCityDropDown.SelectedItem != null)
            {
                List<Flight> flights = new List<Flight>();
                foreach (Ticket ticket in currentUser.GetUpcomingTickets())
                {
                    foreach (Flight flight in ticket.GetFlights())
                    {
                        flights.Add(flight);
                    }
                }

                BoardingPass boarding = new BoardingPass(flights[OriginCityDropDown.SelectedIndex].GetFlightId(), currentUser.GetFirstName(),
                    currentUser.GetLastName(), flights[OriginCityDropDown.SelectedIndex].GetOriginCity(), flights[OriginCityDropDown.SelectedIndex].GetDestinationCity(),
                    flights[OriginCityDropDown.SelectedIndex].GetTime(), flights[OriginCityDropDown.SelectedIndex].EstimateArrivalTime(), currentUser.GetUserId().ToString());
                ShowBoardingPass pass = new ShowBoardingPass(boarding);
                
                pass.ShowDialog();
            }
        }

        // handler for when the button to cancel a ticket is clicked
        private void Cancel_Click(object sender, EventArgs e)
        {
            if(OriginCityDropDown.SelectedItem != null)
            {
                currentUser.GetUpcomingTickets()[OriginCityDropDown.SelectedIndex].CancelTicket();

                NewsFeed.Items.Clear();
                NewsFeed.Items.Add("Air-Ease has been released!");

                upcomingDepartureList.Items.Clear();
                upcomingDepartureList.Items.Add(currentUser.GetUpcomingTickets());

                // update flights with past flights
                listBox2.Items.Clear();
                listBox2.Items.Add("TicketID: Flight ID: Origin City, Destination City, Departure Time and Date");
                foreach (Ticket ticket in currentUser.GetUpcomingTickets())
                {
                    foreach (Flight flight in ticket.GetFlights())
                    {
                        string info = ticket.GetTicketId()      + ": ";
                        info.Concat(flight.GetFlightId()        + ": ");
                        info.Concat(flight.GetOriginCity()      + ", ");
                        info.Concat(flight.GetDestinationCity() + ", ");
                        info.Concat(flight.GetTime().ToString());
                        listBox2.Items.Add(info);
                    }
                }

                // update upcoming flights
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();
                listBox1.Items.Clear();
                foreach (Ticket ticket in currentUser.GetUpcomingTickets())
                {
                    comboBox5.Items.Add(ticket.GetTicketId());
                    listBox1.Items.Add(ticket.GetTicketInformation());
                    foreach (Flight flight in ticket.GetFlights())
                    {
                        comboBox6.Items.Add(flight.GetFlightId() + flight.GetDepartureId());
                    }
                }
            }
        }
    }
}
