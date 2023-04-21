using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Entity.User.Employees;

namespace AirEase_AMS.Interface
{
    public partial class Login : Form
    {
        string username = "";
        string password = "";

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
            password = PasswordBox.Text;
            username = UsernameBox.Text;

            if (Employee.AttemptLogin(username, password))
            {
                //Hide current form
                this.Hide();
                //Customer
                if (username[0] == '1')
                {
                    //Initialize customer class
                    Customer loggedUser = new Customer(username, password);

                    // Setup currentCustomer using a database query for the username

                    Customer currentCustomer;
                    CustomerMain customerInstance = new CustomerMain();
                    this.Hide();
                    customerInstance.ShowDialog();
                    this.Close();

                }
                //Employee
                else
                {

                    EmployeeForm employeeForm;
                    //Initialize employee class and load form
                    switch (username[0])
                    {
                        case '2':
                            Accountant loggedAcc = new Accountant(username, password);
                            //Load employee form
                            employeeForm = new EmployeeForm(loggedAcc);

                            break;
                        case '3':
                            FlightManager loggedFm = new FlightManager(username, password);
                            //Load employee form
                            employeeForm = new EmployeeForm(loggedFm);
                            break;
                        case '4':
                            LoadEngineer loggedLe = new LoadEngineer(username, password);
                            //Load employee form
                            employeeForm = new EmployeeForm(loggedLe);

                            break;
                        case '5':
                            MarketManager loggedMm = new MarketManager(username, password);
                            //Load employee form
                            employeeForm = new EmployeeForm(loggedMm);
                            break;
                        default:
                            //Error
                            return;

                    }
                    employeeForm.ShowDialog();


                }

                //Close out login form
                this.Close();
            }
            else
            {
                string error = "Incorrect username or password.";
                LoginFailureLabel.Text = error;
                LoginFailureLabel.Visible = true;
            }
        }

        //PASSWORD
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //USERNAME
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void LoginFailureLabel_Click(object sender, EventArgs e)
        {

        }
    }
}