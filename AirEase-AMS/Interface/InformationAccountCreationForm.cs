using AirEase_AMS.App;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AirEase_AMS.Interface
{
    public partial class InformationAccountCreationForm : Form
    {
        public InformationAccountCreationForm()
        {
            InitializeComponent();

            //Max date is... today but 18 years in the past. If you were born 18 years ago, you probably aren't creating an account..? Right?
            BirthDateCalendar.MaxDate = DateTime.Now.AddYears(-18);

            //Arbitrarily sets the minimum date to 1900. We don't really want users saying they were born in the 1800's or earlier anyways.
            BirthDateCalendar.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool firstNameMissing = (String.IsNullOrEmpty(FirstNameBox.Text));
            bool lastNameMissing = (String.IsNullOrEmpty(LastNameBox.Text));
            bool addressMissing = (String.IsNullOrEmpty(AddressBox.Text));
            bool emailMissing = (String.IsNullOrEmpty(EmailBox.Text));
            bool birthDateMissing = BirthDateCalendar.ToString == null;
            bool emailFormatCorrect = EmailBox.Text.Contains("@") && EmailBox.Text.Contains(".");
            bool phoneFormatCorrect = PhoneNumberBox.Text.Length == 10 && !PhoneNumberBox.Text.Any(ch => !char.IsNumber(ch));
            bool noDataMissing = !firstNameMissing && !lastNameMissing && !addressMissing && !birthDateMissing && !emailMissing;
            bool fieldsAccurate = emailFormatCorrect && phoneFormatCorrect;

            //If both passwords are null
            bool passwordsMissing = String.IsNullOrEmpty(PasswordFirst.Text) && String.IsNullOrEmpty(PasswordVerify.Text);

            //If one of the passwords is null or if they are not equal
            bool passwordsMatch = passwordsMissing ? true : PasswordFirst.Text.Equals(PasswordVerify.Text);


            string errorMessage = "Create a secure password.\r\nPasswords should be:\r\nGreater than eight characters in length\r\nContain at least one special character\r\nContain at least one number\r\nContain at least one upper case letter\r\nContain at least one lower case letter\r\n\t\n";

            errorMessage +=
                ((firstNameMissing || lastNameMissing || addressMissing || birthDateMissing || passwordsMissing)
                    ? "Please fill out all information.\r\n"
                    : "") +
                (emailFormatCorrect ? "" : "Email is not formatted correctly.\r\n") +
                (phoneFormatCorrect ? "" : "Phone number is not formatted correctly.\r\n") +
                ((passwordsMatch) ? "" : "Passwords do not match.\r\n") +
                (BirthDateCalendar.Equals(DateTime.Now) ? "" : "Birthdate cannot be today.");

            if (passwordsMatch)
            {
                bool passwordContainsUppercase = PasswordFirst.Text.Any(char.IsUpper);
                bool passwordContainsLowercase = PasswordFirst.Text.Any(char.IsLower);
                bool passwordContainsNumeric = PasswordFirst.Text.Any(char.IsNumber);
                bool passwordContainsSpecialChar = PasswordFirst.Text.Any(ch => !char.IsLetterOrDigit(ch));
                bool passwordLengthGreaterThan8 = PasswordFirst.Text.Length > 8;
                bool passwordCorrect = passwordContainsUppercase && passwordContainsLowercase
                    && passwordContainsNumeric && passwordContainsSpecialChar
                    && passwordContainsSpecialChar;

                if (passwordCorrect && noDataMissing && fieldsAccurate)
                {
                    DatabaseAccessObject dao = new DatabaseAccessObject();

                    Customer cs = new Customer(FirstNameBox.Text, LastNameBox.Text, AddressBox.Text, BirthDateCalendar.Text, PasswordFirst.Text, PhoneNumberBox.Text, EmailBox.Text);
                    bool successful = cs.AttemptAccountCreation();
                    if (successful)
                    {
                        AccountCreated ac = new AccountCreated(cs.GetUserId().ToString());
                        this.Hide();
                        ac.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    errorMessage +=
                        (passwordCorrect ? "" : "Password must:\r\n") +
                        (passwordContainsLowercase ? "" : "contain lowercase character\r\n") +
                        (passwordContainsUppercase ? "" : "contain uppercase character\r\n") +
                        (passwordContainsNumeric ? "" : "contain a numeric character\r\n") +
                        (passwordContainsSpecialChar ? "" : "contain special character (!@#$%^...&)\r\n") +
                        (passwordLengthGreaterThan8 ? "" : "have a length exceeding eight characters\r\n");
                }

            }
            ErrorMessageBox.Text = errorMessage;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordFirst_TextChanged(object sender, EventArgs e)
        {
        }
        private void PasswordVerify_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ErrorMessageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void InformationAccountCreationForm_Load(object sender, EventArgs e)
        {
        }
    }
}