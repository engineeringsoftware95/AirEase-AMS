using AirEase_AMS.App;
using AirEase_AMS.App.Entity.Aircraft;
using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Entity.User.Employees;
using AirEase_AMS.App.Graph;
using AirEase_AMS.App.Graph.Flight;
using AirEase_AMS.App.Ticket;
using AirEase_AMS.Transaction;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirEase_AMS.App.Defs.Struct;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AirEase_AMS.Interface
{
    public partial class EmployeeForm : Form
    {
        Employee user;
        public EmployeeForm(Employee loggedUser)
        {
            InitializeComponent();
            user = loggedUser;
            flightTimePicker.MinDate = DateTime.Now;
            flightTimePicker.MaxDate = DateTime.Now.AddMonths(7);

            listBox1.Items.Clear();
            listBox1.Items.Add("Welcome to the company!");

            richTextBox1.Clear();
            richTextBox1.Text = "Hello valued employee!";

            setUp();

            flightTimePicker.Format = DateTimePickerFormat.Custom;
            flightTimePicker.CustomFormat = "MM/dd/yyyy    HH:mm";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gather string from SummaryReport class
            SummaryReport summaryReport = new SummaryReport();
            summaryReport.GenerateReport();

            summaryReportBox.Items.Clear();
            //Set string in SummaryReportBox (textbox)
            if (!string.IsNullOrEmpty(summaryReport.ToString()))
                summaryReportBox.Text = summaryReport.ToString();
            else
                summaryReportBox.Text = "No summary report to display.";

        }

        private void RoutesTab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<IGraphNode> airports = HLib.SelectAllAirports();
            string origin = airports[originView.SelectedIndex].GetAirportId();
            string destination = airports[destinationCombo.SelectedIndex].GetAirportId();
            Route toAdd = new Route(origin, destination, (int)numericUpDown1.Value);
            toAdd.UploadRoute();

            setUp();
        }

        private void flightTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Nothing to see here...");

            richTextBox1.Clear();
            richTextBox1.Text = "Hello World!";

            flightTimePicker.Format = DateTimePickerFormat.Custom;
            flightTimePicker.CustomFormat = "MM/dd/yyyy    HH:mm";
        }

        private void HomeTab_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // get info selected by combobox1 for aircraft info
            // find flight associated combobox2
            List<Aircraft> aircraft = HLib.SelectAllAircraft();
            List<Flight> flights = HLib.SelectAllFlights();
            string aircraftID = aircraft[comboBox1.SelectedIndex].GetAircraftId();
            flights[comboBox2.SelectedIndex].SetPlaneForFlight(aircraftID);

            setUp();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            List<Flight> flights =  HLib.SelectAllFlights();
            string flightID = flights[comboBox4.SelectedIndex].GetFlightId();
            string departureID = flights[comboBox4.SelectedIndex].GetDepartureId();
            FlightManifest manifest = new FlightManifest(flightID, departureID);
            manifest.PopulateManifest();
            richTextBox2.Text = manifest.GetFlightManifest();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setUp()
        {
            string username = user.GetUserId().ToString();
            switch (username[0])
            {
                case '2':
                    //remove all tabs accountant doesnt need
                    tabControl1.TabPages.Remove(MarketsTab);
                    tabControl1.TabPages.Remove(FlightsTab);
                    tabControl1.TabPages.Remove(RoutesTab);
                    break;
                case '3':
                    //remove all tabs flight manager doesnt need
                    tabControl1.TabPages.Remove(MarketsTab);
                    tabControl1.TabPages.Remove(RoutesTab);
                    tabControl1.TabPages.Remove(AccountsTab);

                    comboBox4.Items.Clear();
                    foreach (Flight flight in HLib.SelectAllFlights())
                    {
                        comboBox4.Items.Add("" + flight.GetFlightId() + ", " + flight.GetTime());
                    }
                    break;
                case '4':
                    //remove all tabs load engineer doesnt need
                    tabControl1.TabPages.Remove(MarketsTab);
                    tabControl1.TabPages.Remove(FlightsTab);
                    tabControl1.TabPages.Remove(AccountsTab);

                    originView.Items.Clear();
                    destinationCombo.Items.Clear();
                    foreach (Airport city in HLib.SelectAllAirports())
                    {
                        originView.Items.Add(city.GetCityName());         // list of all cities in graph
                        destinationCombo.Items.Add(city.GetCityName());
                    }

                    comboBox3.Items.Clear();
                    loadEnginList.Rows.Clear();
                    foreach (Route route in HLib.SelectAllRoutes())
                    {
                        comboBox3.Items.Add(route.GetRouteId());            // list of all routes
                        loadEnginList.Rows.Add(route.GetRouteId(), route.GetOriginCity(), route.GetDestinationCity());
                    }
                    break;
                case '5':
                    //remove all tabs market manager doesnt need
                    tabControl1.TabPages.Remove(FlightsTab);
                    tabControl1.TabPages.Remove(RoutesTab);
                    tabControl1.TabPages.Remove(AccountsTab);

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();
                    foreach (Aircraft plane in HLib.SelectAllAircraft())
                    {
                        comboBox1.Items.Add(plane.GetModelName());                  // list of all planes
                        dataGridView1.Rows.Add(plane.GetAircraftId(), plane.GetModelName());
                    }

                    foreach (Flight flight in HLib.SelectAllFlights())
                    {
                        comboBox2.Items.Add("" + flight.GetFlightId() + ", " + flight.GetTime().ToString());
                        dataGridView2.Rows.Add(flight.GetFlightId(), flight.GetTime(), flight.GetOriginCity(), flight.GetDestinationCity(), flight.GetAircraftID());
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    return;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddFlightButton_Click_1(object sender, EventArgs e)
        {
            List<Route> routes = HLib.SelectAllRoutes();
            string routeid = routes[comboBox3.SelectedIndex].GetRouteId();
            Flight toAdd = new Flight(routeid, HLib.GenerateYearWeekID(flightTimePicker.Value), flightTimePicker.Value);
            toAdd.UploadFlight();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void originView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            Close();
        }
    }
}
