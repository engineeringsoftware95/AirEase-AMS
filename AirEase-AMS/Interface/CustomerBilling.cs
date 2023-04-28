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
        Customer currentUser;
        string origin;
        string destination;
        decimal ticketCost;
        string departureDate;
        public CustomerBilling(Customer loggedIn, string originCity, string destinationCity)
        {
            currentUser = loggedIn;
            origin = originCity;
            destination = destinationCity;
            //ticketCost = ;
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
    }
}
