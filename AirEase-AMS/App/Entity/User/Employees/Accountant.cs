namespace AirEase_AMS.App.Entity.User.Employees;

public class Accountant : Employee
{
    Accountant() : base() { } //TODO: statement or branch uncovered
    public Accountant(string fName, string lName, string address, string date, string password, string phoneNum, string email, string ssn)
    {
        _roleBit = 2;
        _positionTitle = "Accountant";
        _firstName = fName;
        _lastName = lName;
        _email = email;
        _phoneNum = phoneNum;
        _address = address;
        _birthDate = date;
        _salt = HLib.GenerateSalt(32);
        _password = HLib.EncryptPassword(password, _salt);
        _ssn = ssn;
        _userId = GenerateId();
    }

    public Accountant(string username, string password) : base(username, password) //TODO: statement or branch uncovered
    {

    }
}