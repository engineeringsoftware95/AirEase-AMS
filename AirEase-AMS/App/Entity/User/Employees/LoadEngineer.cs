namespace AirEase_AMS.App.Entity.User.Employees;

public class LoadEngineer : Employee
{
    //This is similar to a member initializer list from cpp - instead of copying the memory over, and rereading it in the function contents, it sets the data the first time its copied over
    public LoadEngineer(string fName, string lName, string address, string date, string password, string phoneNum, string email, string ssn) =>
        (_firstName, _lastName, _address, _birthDate, _salt, _phoneNum, _email, _ssn, _positionTitle, _roleBit, _password) = (fName, lName, address, date, HLib.GenerateSalt(32), phoneNum, email, ssn, "Load Engineer", 4, HLib.EncryptPassword(password, _salt));

}