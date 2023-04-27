using AirEase_AMS.App.Entity.User;
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
    public partial class PaymentInformationEntry : Form
    {
        Customer currentUser;
        Form parent;
        public PaymentInformationEntry(Customer loggedIn, Form calledFrom)
        {
            parent = calledFrom;
            currentUser = loggedIn;
            InitializeComponent();
        }

        private void continue_Click(object sender, EventArgs e)
        {
            // update database with payment info
            this.Hide();
            parent.Show();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PaymentInformationEntry_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
