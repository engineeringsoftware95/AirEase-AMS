using AirEase_AMS.App.Entity.User.Employees;
using System.Data;

namespace AirEase_AMS.App.Entity.User;

public class Employee : User
{
    public Employee() { } //TODO: statement or branch uncovered
    public Employee(string fName, string lName, string address, string date, string password, string phoneNum, string email, string ssn) : base(fName, lName, email, phoneNum, address, date, password)
    {
        _salt = HLib.GenerateSalt(32);
        _password = HLib.EncryptPassword(password, _salt);
        _ssn = ssn;
        _positionTitle = "";
    }

    public Employee(string username) //TODO: statement or branch uncovered
    {
        string query = "SELECT * FROM EMPLOYEE WHERE UserID = " + username + ";";
        DatabaseAccessObject dao = new DatabaseAccessObject();

        System.Data.DataTable dt = dao.Retrieve(query);
        //Empty constructor
        if (dt.Rows.Count != 1) //TODO: statement or branch uncovered
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
        //Load info
        else //TODO: statement or branch uncovered
        { 
            DataRow user = dt.Rows[0];
            _firstName = user["FirstName"].ToString() ?? "";
            _lastName = user["LastName"].ToString() ?? "";
            string id = user["UserID"].ToString() ?? "-1";
            _userId = int.Parse(id);
            _address = user["EmployeeAddress"].ToString() ?? "";
            _phoneNum = user["PhoneNum"].ToString() ?? "";
            _birthDate = user["BDate"].ToString() ?? "";
            _salt = user["Salt"].ToString() ?? "";
            _email = user["Email"].ToString() ?? "";
            _ssn = user["SSN"].ToString() ?? "";
            _positionTitle = user["PositionTitle"].ToString() ?? "";
        }
    }
}