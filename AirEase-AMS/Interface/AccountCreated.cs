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
    public partial class AccountCreated : Form
    {
        public AccountCreated(string userID)
        {
            InitializeComponent();
            DatabaseAccessObject dao = new DatabaseAccessObject();


            string message = "You have successfully created an account.\r\nYour user ID is: " + userID+"\r\nClicking continue will bring you back to the login page.";

            UserIDBox.Text = message;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
