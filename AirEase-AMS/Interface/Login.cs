using AirEase_AMS.App.Entity.User;

namespace AirEase_AMS.Interface
{
    public partial class Login : Form
    {
        string username;
        string password;

        public Login()
        {
            InitializeComponent();
        }

        //This is the image. Ignore
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        //SUBMIT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            password= PasswordBox.Text;
            username= UsernameBox.Text;
            if(true)// Customer.AttemptLogin(username, password))
            {
                // Setup currentCustomer using a database query for the username

                //Customer currentCustomer;
                CustomerMain customerInstance = new CustomerMain();
                this.Hide();
                customerInstance.ShowDialog();
                this.Close();
            }
            else if(Employee.AttemptLogin(username, password))
            {
                this.Hide();
                this.Close();
            }
            else
            {
                string error = "Incorrect username or password.";
                LoginFailureLabel.Text = error;
            }
        }

        //PASSWORD
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = e.ToString() ?? "";
        }

        //USERNAME
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = e.ToString() ?? "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InformationAccountCreationForm personalAccountCreationForm = new InformationAccountCreationForm();
            this.Hide();
            personalAccountCreationForm.ShowDialog();
            this.Close();
        }
    }
}