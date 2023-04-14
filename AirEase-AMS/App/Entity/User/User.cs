using AirEase_AMS.App.Defs;
using System.Security.Cryptography.X509Certificates;

namespace AirEase_AMS.App.Entity.User;

public class User : IUser
{
    protected int _roleBit;
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phoneNum;
    private string _address;
    private string _birthDate;
    private string _password;
    private string _salt;
    private int _userId;

    public User()
    {
        _firstName = "";
        _lastName = "";
        _email = "";
        _phoneNum = "";
        _address = "";
        _birthDate = "";
        _password = "";
        _salt = "";
        _userId = -1;
    }
    public User(string firstName, string lastName, string email, string phoneNum, string address, string birthDate, string password, string salt, int userId)
    {
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _phoneNum = phoneNum;
        _address = address;
        _birthDate = birthDate;
        _password = password;
        _userId = userId;
        _salt = salt;
    }

    public void SetFirstName(string first)
    {
        _firstName = DatabaseAccessObject.SanitizeString(first);
    }

    public void SetLastName(string last)
    {
        _lastName = DatabaseAccessObject.SanitizeString(last);
    }

    public void SetPhoneNum(string num)
    {
        _phoneNum = DatabaseAccessObject.SanitizeString(num);
    }

    public void SetEmail(string email)
    {
        _email = DatabaseAccessObject.SanitizeString(email);
    }

    public void SetBirthDate(string bday)
    {
        _birthDate = bday;
    }

    public void SetPassword(string pass)
    {
        _password = DatabaseAccessObject.SanitizeString(pass);
    }

    public void SetAddress(string addr)
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

    public void SetSalt(string salt)
    {
        _salt = DatabaseAccessObject.SanitizeString(salt);
    }

    public string GetFirstName()
    {
        return _firstName;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string GetPassword()
    {
        return _password;
    }

    public string GetPhoneNum()
    {
        return _phoneNum;
    }

    public string GetBirthDate()
    {
        return _birthDate;
    }

    public int GetUserId()
    {
        return _userId;
    }

    public string GetAddress()
    {
        return _address;
    }

    public string GetSalt()
    {
        return _salt;
    }

    public int GetRole()
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

        //While the ID isn't unique, make a new one.
        while(dao.Retrieve("SELECT * FROM " + table + " WHERE UserID=" + GetUserId() + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            SetId(GenerateId());
        }

        //Now we have a unique ID and a user class loaded with information - we can attempt to push it to the Database
        if(role == 1)
        {
            //Try to create the customer
            string query = "INSERT INTO CUSTOMER VALUES(" + GetUserId() + ", '" + GetPassword() + "', '" + GetFirstName() + "', '" + GetLastName() + "', '" + GetAddress() + "', '" + GetPhoneNum() + "', '" + GetBirthDate() + "', 0.0, 0, '" + GetSalt() + "', '" + GetEmail() + "');";
            int results = dao.Update(query);

            //Returns whether or not a row was created
            return results > 0;
        }
        
        //The funtion failed somewhere
        return false;
    }

    /// <summary>
    /// This function takes a username and password and returns
    /// whether the account exists with the given credentials.
    /// </summary>
    /// <param name="username">The input username.</param>
    /// <param name="password">The input password.</param>
    /// <returns>If the login was successful.</returns>
    public static bool AttemptLogin(string username, string password)
    {
        string table = (username[0] == '1') ? "CUSTOMER" : "EMPLOYEE";

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
        if(rows.Length <= 0) { return false; }

        //Encrypt the password with our salt
        string salt = rows[0]["Salt"].ToString() ?? "";
        password = HLib.EncryptPassword(password, salt);

        //Login verified
        query = "SELECT * FROM " + table + " WHERE UserPassword = '" + password + "' AND UserID = " + username + ";";
        
        //Return whether our select returned a match
        return (dao.Retrieve(query).Rows.Count == 1);
    }

}