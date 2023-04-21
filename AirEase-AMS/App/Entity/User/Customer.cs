﻿using AirEase_AMS.App.Defs;
using System.Data;

namespace AirEase_AMS.App.Entity.User;

public class Customer : User
{
    public Customer(string fName, string lName, string address, string date, string password, string phoneNum, string email)
    : base(fName, lName, address, date, password, phoneNum, email)
    {
        SetRole(1);
        SetId(GenerateId());
    }

    public Customer(string username, string password)
    {
        string query = "SELECT * FROM Customer WHERE UserPassword = '" + password + "' AND UserID = " + username + ";";
        DatabaseAccessObject dao = new DatabaseAccessObject();

        System.Data.DataTable dt = dao.Retrieve(query);
        //Empty constructor
        if (dt.Rows.Count != 1)
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
        else
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
        }
    }


}