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
        private List<Ticket> returnTickets;
        private DateTime selectedDeparture_OW;
        private DateTime selectedDeparture_RT;

        public CustomerMain(Customer loggedIn)
        {
            origin = new Airport();
            dest = new Airport();
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
            Ticket firstTicket = new Ticket();
            CustomerBilling billing;
            string firstTicketId = comboBox1.GetItemText(OriginCityDropDown.SelectedItem);
            foreach (Ticket t in availableTickets)
            {
                if (t.GetTicketId() == firstTicketId)
                {
                    firstTicket = t;
                    break;
                }
            }

            if (RoundTrip.Checked)
            {
                // get ticket selected in combobox 1
                // get ticket selected in combobox 4
                Ticket secondTicket = new Ticket();
                string secondTicketId = comboBox4.GetItemText(OriginCityDropDown.SelectedItem);
                if (secondTicketId != null)
                {
                    comboBox4.Items.Add("No valid tickets.");
                }

                foreach (Ticket t in returnTickets)
                {
                    if (t.GetTicketId() == secondTicketId)
                    {
                        secondTicket = t;
                        break;
                    }
                }

                if (secondTicketId != null)
                {
                    billing = new CustomerBilling(this, currentUser, secondTicket);
                    this.Hide();
                    billing.ShowDialog();
                }
            }
            else
            {
                // get ticket selected in combobox 1
                billing = new CustomerBilling(this, currentUser, firstTicket);
                this.Hide();
                billing.ShowDialog();
            }
        }

        // this is the handler for the search button in the customer booking tab
        private void Search_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            comboBox1.Items.Clear();

            selectedDeparture_OW = DateTimePicker_OW.Value.Date;
            availableTickets = GetTickets(origin.GetCityName(), dest.GetCityName());

            if (RoundTrip.Checked)
            {
                selectedDeparture_RT = DateTimePicker_OW.Value.Date;
                returnTickets = GetTickets(dest.GetCityName(), origin.GetCityName());
            }

            foreach (Ticket ticket in availableTickets)
            {
                comboBox1.Items.Add(ticket.GetTicketId());
                dataGridView4.Rows.Add(ticket.GetTicketId(), ticket.GetTicketCost(), ticket.GetFlights()[0].GetTime(), ticket.GetOriginCity(),
                    ticket.GetDestinationCity(), ticket.GetFlights()[0].GetSeatsTaken());
            }

            if (RoundTrip.Checked)
            {
                comboBox4.Items.Clear();
                foreach (Ticket ticket in returnTickets)
                {
                    comboBox4.Items.Add(ticket.GetTicketId());
                    dataGridView4.Rows.Add(ticket.GetTicketId(), ticket.GetTicketCost(),
                        ticket.GetFlights()[0].GetTime(), ticket.GetOriginCity(),
                        ticket.GetDestinationCity(), ticket.GetFlights()[0].GetSeatsTaken());
                }
            }

            // first clear table
            // get list of flights that match query
            // update table
            Console.WriteLine(":)");
            // dataGridView4.Rows.Clear();
            // populate the rows with all of the flights that match the given parameters
            // allow selection of ticketID
        }


        public List<Ticket> GetTickets(string startCity, string endCity)
        {
            List<List<IRoute>> routesToDestination = airportGraph.FindRoutes(origin.GetCityName(), dest.GetCityName());
            List<Ticket> tickets = new List<Ticket>();
            Ticket t = new Ticket();

            List<Flight> OriginDepartures = new List<Flight>();
            List<Flight> LayoverDepartures = new List<Flight>();
            // get direct flights
            foreach (Flight f in routesToDestination[0][0].GetFlightsOnRoute())
            {
                t.SetStartCity(startCity);
                t.SetEndCity(endCity);
                t.AddFlight(f);
                tickets.Add(t);
                t = new Ticket();
            }


            if (routesToDestination[1].Count > 0) // Create list of origin and layover
            {
                for (int i = 0; i < routesToDestination[1].Count; i++)
                {
                    foreach (Flight f in routesToDestination[1][i].GetFlightsOnRoute())
                    {
                        if (f.Origin().GetCityName() == origin.GetCityName())
                        {
                            OriginDepartures.Add(f);
                            continue;
                        }

                        LayoverDepartures.Add(f);
                    }
                }

                foreach (Flight orig in OriginDepartures)
                {
                    foreach (Flight lyvr in LayoverDepartures)
                    {
                        TimeSpan departureTime = orig.EstimateArrivalTime().TimeOfDay;
                        TimeSpan finalArrival = lyvr.GetTime().TimeOfDay;
                        if (finalArrival.TotalMinutes >= departureTime.TotalMinutes + 40)
                        {
                            t = new Ticket();
                            t.AddFlight(orig);
                            t.AddFlight(lyvr);
                            tickets.Add(t);
                        }
                    }
                }
            }


            if (routesToDestination[2].Count > 0) // Create list of origin and layover
            {
                OriginDepartures = new List<Flight>();
                LayoverDepartures = new List<Flight>();
                List<Flight> FinalLayovers = new List<Flight>();
                for (int i = 0; i < routesToDestination[1].Count; i++)
                {
                    foreach (Flight f in routesToDestination[1][i].GetFlightsOnRoute())
                    {
                        if (f.Origin().GetCityName() == origin.GetCityName())
                        {
                            OriginDepartures.Add(f);
                            continue;
                        }

                        LayoverDepartures.Add(f);
                    }
                }

                foreach (Flight f in LayoverDepartures)
                {
                    if (f.Destination().GetCityName() == dest.GetCityName())
                    {
                        FinalLayovers.Add(f);
                        LayoverDepartures.Remove(f);
                    }
                }


                foreach (Flight orig in OriginDepartures)
                {
                    foreach (Flight lyvr in LayoverDepartures)
                    {
                        TimeSpan departureTime = orig.EstimateArrivalTime().TimeOfDay;
                        TimeSpan finalArrival = lyvr.GetTime().TimeOfDay;
                        if (finalArrival.TotalMinutes >= departureTime.TotalMinutes + 40)
                        {
                            foreach (Flight finalLayover in FinalLayovers)
                            {
                                TimeSpan layoverTime = finalLayover.EstimateArrivalTime().TimeOfDay;
                                TimeSpan finalLayoverDepartureTime = finalLayover.GetTime().TimeOfDay;
                                if (finalLayoverDepartureTime.TotalMinutes >= layoverTime.TotalMinutes + 40)
                                {
                                    t = new Ticket();
                                    t.AddFlight(orig);
                                    t.AddFlight(lyvr);
                                    t.AddFlight(finalLayover);
                                    tickets.Add(t);
                                }
                            }
                        }
                    }
                }
            }

            return tickets;
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
                foreach (Flight flight in ticket.GetFlights())
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

        // handler for when the booking tab is clicked
        private void Booking_Click(object sender, EventArgs e)
        {
        }

        // handler for when the button to print a boarding pass is clicked
        private void BoardingPass_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null)
            {
                label6.Visible = false;
                List<Flight> flights = new List<Flight>();
                foreach (Ticket ticket in currentUser.GetUpcomingTickets())
                {
                    foreach (Flight flight in ticket.GetFlights())
                    {
                        flights.Add(flight);
                    }
                }

                BoardingPass boarding = new BoardingPass(flights[comboBox5.SelectedIndex].GetFlightId(),
                    currentUser.GetFirstName(),
                    currentUser.GetLastName(), flights[comboBox5.SelectedIndex].GetOriginCity(),
                    flights[comboBox5.SelectedIndex].GetDestinationCity(),
                    flights[comboBox5.SelectedIndex].GetTime(),
                    flights[comboBox5.SelectedIndex].EstimateArrivalTime(),
                    currentUser.GetUserId().ToString());
                ShowBoardingPass pass = new ShowBoardingPass(boarding);

                pass.ShowDialog();
            }
            else
            {
                label6.Visible = true;
                label6.Text = "Please select a flight before printing the boarding pass";
            }
        }

        // handler for when the button to cancel a ticket is clicked
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (OriginCityDropDown.SelectedItem != null)
            {
                label7.Visible = false;

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
                    foreach (Flight flight in ticket.GetFlights())
                    {
                        comboBox6.Items.Add(flight.GetFlightId() + flight.GetDepartureId());
                    }
                }
            }
            else
            {
                label7.Visible = true;
                label7.Text = "Please select a ticket to cancel.";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}