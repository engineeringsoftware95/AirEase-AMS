using AirEase_AMS.App.Defs;
using Microsoft.Identity.Client;
using System.Security.Cryptography.X509Certificates;

namespace AirEase_AMS.App.Entity.User;

public class User : Defs.IUser
{
    protected   int        _roleBit;
    protected string     _firstName;
    protected string      _lastName;
    protected string         _email;
    protected string      _phoneNum;
    protected string       _address;
    protected string     _birthDate;
    protected string      _password;
    protected string          _salt;
    protected string           _ssn;
    protected string _positionTitle;
    protected int           _userId;
    public decimal      _cashBalance { get; set; }
    public int         _pointBalance { get; set; }



    public User() //TODO: statement or branch uncovered
    {
        _firstName = "";
        _lastName = "";
        _email = "";
        _phoneNum = "";
        _address = "";
        _birthDate = "";
        _password = "";
        _salt = "";
        _ssn = "";
        _positionTitle = "";
        _userId = -1;
    }

    public User(string fName, string lName, string address, string date, string password, string phoneNum, string email)
    {
        _firstName = fName;
        _lastName = lName;
        _email = email;
        _phoneNum = phoneNum;
        _address = address;
        _birthDate = date;
        _salt = (HLib.GenerateSalt(32));
        _password = (HLib.EncryptPassword(password, GetSalt()));
        _ssn = "";
        _positionTitle = "";
    }

    public void SetFirstName(string first)
    {
        _firstName = DatabaseAccessObject.SanitizeString(first);
    }

    public void SetLastName(string last) //TODO: statement or branch uncovered
    {
        _lastName = DatabaseAccessObject.SanitizeString(last);
    }

    public void SetPhoneNum(string num) //TODO: statement or branch uncovered
    {
        _phoneNum = DatabaseAccessObject.SanitizeString(num);
    }

    public void SetEmail(string email) //TODO: statement or branch uncovered
    {
        _email = DatabaseAccessObject.SanitizeString(email);
    }

    public void SetBirthDate(string bday) //TODO: statement or branch uncovered
    {
        _birthDate = bday;
    }

    public void SetPassword(string pass) //TODO: statement or branch uncovered
    {
        _password = DatabaseAccessObject.SanitizeString(pass);
    }

    public void SetAddress(string addr) //TODO: statement or branch uncovered
    {
        _address = DatabaseAccessObject.SanitizeString(addr);
    }

    public void SetId(int id)
    {
        _userId = id;
    }

    public void SetRole(int role)
    {
        _roleBit = role;
    }

    public void SetSalt(string salt) //TODO: statement or branch uncovered
    {
        _salt = DatabaseAccessObject.SanitizeString(salt);
    }

    public void SetSsn(string ssn) //TODO: statement or branch uncovered
    {
        _ssn = DatabaseAccessObject.SanitizeString(ssn);
    }

    public void SetTitle(string title) //TODO: statement or branch uncovered
    {
        _positionTitle = DatabaseAccessObject.SanitizeString(title);
    }

    public string GetFirstName() //TODO: statement or branch uncovered
    {
        return _firstName;
    }

    public string GetLastName() //TODO: statement or branch uncovered
    {
        return _lastName;
    }

    public string GetEmail() //TODO: statement or branch uncovered
    {
        return _email;
    }

    public string GetPassword() //TODO: statement or branch uncovered
    {
        return _password;
    }

    public string GetPhoneNum() //TODO: statement or branch uncovered
    {
        return _phoneNum;
    }

    public string GetBirthDate() //TODO: statement or branch uncovered
    {
        return _birthDate;
    }

    public int GetUserId()
    {
        return _userId;
    }

    public string GetAddress() //TODO: statement or branch uncovered
    {
        return _address;
    }

    public string GetSalt()
    {
        return _salt;
    }

    public string GetSsn() //TODO: statement or branch uncovered
    {
        return _ssn;
    }

    public string GetTitle() //TODO: statement or branch uncovered
    {
        return _positionTitle;
    }

    public int GetRole() //TODO: statement or branch uncovered
    { 
        return _roleBit;
    }

    public int GenerateId()
    {
        // get five digit ID
        int fiveDigitId = HLib.GenerateFiveDigitId();
        return HLib.PrependNumberToInteger(_roleBit, fiveDigitId);
    }

    /// <summary>
    /// This function takes the class members and attempts to create an account.
    /// </summary>
    /// <returns>Returns whether or not it was successful.</returns>
    public bool AttemptAccountCreation()
    {

        bool fNameEmpty = String.IsNullOrEmpty(_firstName);
        bool lNameEmpty = String.IsNullOrEmpty(_lastName);
        bool addressEmpty = String.IsNullOrEmpty(_address);
        bool saltEmpty = String.IsNullOrEmpty(_salt);
        bool emailEmpty = String.IsNullOrEmpty(_email);
        bool passwordEmpty = String.IsNullOrEmpty(_password);
        bool phoneNumEmpty = String.IsNullOrEmpty(_phoneNum);
        bool bDateEmpty = String.IsNullOrEmpty(_birthDate);

        //Do not create account if field is missing
        if (fNameEmpty || lNameEmpty || emailEmpty || passwordEmpty || addressEmpty || saltEmpty || phoneNumEmpty || bDateEmpty) return false;
        
        int role = _roleBit;
        string table = (role == 1) ? "CUSTOMER" : "EMPLOYEE"; 
        DatabaseAccessObject dao = new DatabaseAccessObject();

        //If not connected, return false
        if (!dao.IsConnected) return false;

        //While the ID isn't unique, make a new one.
        _userId = GenerateId();
        while (dao.Retrieve("SELECT * FROM " + table + " WHERE UserID=" + GetUserId() + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _userId = GenerateId();
        }

        //Now we have a unique ID and a user class loaded with information - we can attempt to push it to the Database
        //Customer
        if(role == 1) //TODO: statement or branch uncovered
        {
            //Try to create the customer
            string query = "INSERT INTO CUSTOMER VALUES(" + GetUserId() + ", '" + GetPassword() + "', '" + GetFirstName() + "', '" + GetLastName() + "', '" + GetAddress() + "', '" + GetPhoneNum() + "', '" + GetBirthDate() + "', 0.0, 0, '" + GetSalt() + "', '" + GetEmail() + "');";
            int results = dao.Update(query);

            //Returns whether or not a row was created
            return results > 0;
        }
        //Employee
        else //TODO: statement or branch uncovered
        {
            //Try to create the employee
            string query = "INSERT INTO EMPLOYEE VALUES(" + GetUserId() + ", '" + GetPassword() + "', '" + GetFirstName() + "', '" + GetLastName() + "', '" + GetAddress() + "', '" + GetPhoneNum() + "', '" + GetBirthDate() + "', '" + GetSalt() + "', '" + GetEmail() + "', '"+GetSsn()+"', '"+GetTitle()+"');";
            int results = dao.Update(query);

            //Returns whether or not a row was created
            return results > 0;
        }
    }

    /// <summary>
    /// This function takes a username and password and returns
    /// whether the account exists with the given credentials.
    /// </summary>
    /// <param name="username">The input username.</param>
    /// <param name="password">The input password.</param>
    /// <returns>If the login was successful.</returns>
    public static bool AttemptLogin(string username, string password) 
    { //TODO: statement or branch uncovered
        if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) { return false; }
        char roleBit = username[0];
        string table = (roleBit == '1') ? "CUSTOMER" : "EMPLOYEE";
        string passwordColumn = (roleBit == '1') ? "UserPassword" : "EmployeePassword";

        //Sanitize user inputs
        username = DatabaseAccessObject.SanitizeString(username);
        password = DatabaseAccessObject.SanitizeString(password);

        DatabaseAccessObject dao = new DatabaseAccessObject();

        //Get the salt associated with this username
        string query = "SELECT Salt FROM "+table+" WHERE UserID = " + username + ";";

        //Get salt from row[0]
        System.Data.DataTable dt = dao.Retrieve(query);
        System.Data.DataRow[] rows = dt.Select();

        //No match
        if(rows.Length <= 0) { return false; } //TODO: statement or branch uncovered

        //Encrypt the password with our salt
        string salt = rows[0]["Salt"].ToString() ?? "";
        password = HLib.EncryptPassword(password, salt);

        //Login verified
        query = "SELECT * FROM " + table + " WHERE "+passwordColumn+" = '" + password + "' AND UserID = " + username + ";";
        
        //Return whether our select returned a match
        return (dao.Retrieve(query).Rows.Count == 1);
    }

    /// <summary>
    /// Gets any upcoming tickets related to this users account.
    /// </summary>
    /// <returns>A list of tickets.</returns>
    public List<App.Ticket.Ticket> GetUpcomingTickets()
    {
        //The current date
        DateTime time = DateTime.Now;

        //Calculate our yearWeekId
        string yearWeekId = time.Year.ToString();
        yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();

        //Create our query to execute the stored procedure
        string query = String.Format("EXEC SelectFutureTickets @CustomerId = {0}, @YearWeekID={1};", _userId, yearWeekId);
        DatabaseAccessObject dao = new DatabaseAccessObject();

        //Get our table of ticket information
        System.Data.DataTable dt = dao.Retrieve(query);

        //Initialize our return array of tickets
        List<App.Ticket.Ticket> tickets = new List<Ticket.Ticket>();
        foreach(System.Data.DataRow row in dt.Rows)
        {
            //For each ticket in the table, add it to our list of tickets
            tickets.Add(new Ticket.Ticket(row["TicketID"].ToString() ?? "-1"));
        }
        
        Console.Write(":(");
        //Return our list of tickets
        return tickets;
    }

    /// <summary>
    /// Gets a history of tickets associated with this account.
    /// </summary>
    /// <returns>A list of tickets.</returns>
    public List<App.Ticket.Ticket> GetPastTickets()
    {
        //The current date
        DateTime time = DateTime.Now;

        //Calculate our yearWeekId
        string yearWeekId = time.Year.ToString();
        yearWeekId += ((int)Math.Floor(time.DayOfYear / 7.0)).ToString();

        //Create our query to execute the stored procedure
        string query = String.Format("EXEC SelectPastTickets @CustomerId = {0}, @YearWeekID={1};", _userId, yearWeekId);
        DatabaseAccessObject dao = new DatabaseAccessObject();

        //Get our table of ticket information
        System.Data.DataTable dt = dao.Retrieve(query);

        //Initialize our return array of tickets
        List<App.Ticket.Ticket> tickets = new List<Ticket.Ticket>();
        foreach (System.Data.DataRow row in dt.Rows)
        {
            //For each ticket in the table, add it to our list of tickets
            tickets.Add(new Ticket.Ticket(row["TicketID"].ToString() ?? "-1"));
        }

        //Return our list of tickets
        return tickets;
    }

}