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
            listBox1.Items.Add("Nothing to see here...");

            richTextBox1.Clear();
            richTextBox1.Text = "Hello World!";

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
            string summaryText;

            //if (!string.IsNullOrEmpty(summaryReport.ToString()))
            //    summaryText = summaryReport.ToString();
            //else
                summaryText = "Error occured when generating summary report";
            //Set string in SummaryReportBox (textbox)
            summaryReportBox.Items.Add(summaryText);
        }

        private void RoutesTab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

            setUp();

            flightTimePicker.Format = DateTimePickerFormat.Custom;
            flightTimePicker.CustomFormat = "MM/dd/yyyy    HH:mm";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            // get info selected by datagridview2
            // find flight associated with the info
            // set the aircraft for the selected flight
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //FlightManifest manifest = new FlightManifest();
            //manifest.PopulateManifest();
            //flightManifestWindow.DataSource = manifest.GetFlightManifest();
        }

        private void summaryReportWindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        originView.Items.Add(city.GetAirportName());         // list of all cities in graph
                        destinationCombo.Items.Add(city.GetAirportName());
                    }

                    comboBox3.Items.Clear();
                    dataGridView1.Rows.Clear();

                    foreach (Route route in HLib.SelectAllRoutes())
                    {
                        comboBox3.Items.Add(route.GetRouteId());            // list of all routes
                        dataGridView1.Rows.Add(route);
                    }
                    break;
                case '5':
                    //remove all tabs market manager doesnt need
                    tabControl1.TabPages.Remove(FlightsTab);
                    tabControl1.TabPages.Remove(RoutesTab);
                    tabControl1.TabPages.Remove(AccountsTab);

                    comboBox1.Items.Clear();
                    foreach (Aircraft plane in HLib.SelectAllAircraft())
                    {
                        comboBox3.Items.Add(plane.GetModelName());            // list of all routes
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    return;
            }
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            //add route between the two cities selected

            //then update the route combo box
            comboBox3.Items.Clear();
            foreach (Route route in HLib.SelectAllRoutes())
            {
                flightManifestWindow.Rows.Add(route);            // list of all routes
            }
        }
    }
}
