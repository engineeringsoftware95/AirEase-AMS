namespace AirEase_AMS.App.Entity.User.Employees;

public class FlightManager : Employee
{
    FlightManager() : base() { } //TODO: statement or branch uncovered
    public FlightManager(string fName, string lName, string address, string date, string password, string phoneNum, string email, string ssn)
    {
        _roleBit = 3;
        _positionTitle = "Flight Manager";
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

    public FlightManager(string username, string password) : base(username, password) //TODO: statement or branch uncovered
    {

    }
}