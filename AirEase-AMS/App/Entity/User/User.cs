using AirEase_AMS.App.Defs;

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

    public bool AttemptAccountCreation()
    {
        int role = GetRole();
        string table = (role == 1) ? "CUSTOMER" : "EMPLOYEE"; 
        DatabaseAccessObject dao = new DatabaseAccessObject();
        while(dao.Retrieve("SELECT * FROM " + table + " WHERE UserID=" + GetUserId() + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            SetId(GenerateId());
        }

        //Now we have a unique ID and a user class loaded with information - we can attempt to push it to the Database
        if(role == 1)
        {
            dao.Update("INSERT INTO CUSTOMER VALUES(" + GetUserId() + ", '" + GetPassword() + "', '" + GetFirstName() + "', '" + GetLastName() + "', '" + GetAddress() + "', '" + GetPhoneNum() + "', '" + GetBirthDate() + "', 0.0, 0, '" + GetSalt() + "', '" + GetEmail() + "');");
        }
        

        return false;
    }

    public static bool AttemptLogin(string username, string password)
    {
        string salt = HLib.GenerateSalt(32);
        string table = (username[0] == 1) ? "CUSTOMER" : "EMPLOYEE";
        password = HLib.EncryptPassword(password, salt);
        DatabaseAccessObject dao = new DatabaseAccessObject();
        username = DatabaseAccessObject.SanitizeString(username);
        password = DatabaseAccessObject.SanitizeString(password);
        //Login verified
        return (dao.Retrieve("SELECT * FROM " + table + " WHERE PASSWORD = '" + password + "' AND UserID = " + username + ";").Rows.Count == 1);
    }

}