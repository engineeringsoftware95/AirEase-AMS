using AirEase_AMS.App.Entity.User;
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
        string origin;
        string destination;
        string departureDate;
        public CustomerBilling(Form calledFrom, Customer loggedIn, string originCity, string destinationCity, string depatureDate)
        {
            parent = calledFrom;
            currentUser = loggedIn;
            origin = originCity;
            destination = destinationCity;
            InitializeComponent();
        }

        private void CustomerBilling_Load(object sender, EventArgs e)
        {

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
            //Ticket purchasing = new Ticket();
            //SummaryPage summaryPage = new SummaryPage(currentUser);
            this.Hide();
            //summaryPage.Show();
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
    }
}
