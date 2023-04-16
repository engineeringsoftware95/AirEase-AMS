namespace AirEase_AMS.App.Entity.User.Employees;

public class LoadEngineer : Employee
{
    LoadEngineer() : base() { }

    public LoadEngineer(string fName, string lName, string address, string date, string password, string phoneNum, string email, string ssn)
    {
        _roleBit = 4;
        _positionTitle = "Load Engineer";
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

    public LoadEngineer(string username, string password) : base(username, password)
    {

    }

}