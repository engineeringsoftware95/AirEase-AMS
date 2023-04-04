using AirEase_AMS.Application.Defs;

namespace AirEase_AMS.Application.Entity.User;

public class User : IUser
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phoneNum;
    private string _address;
    private string _birthDate;
    private string _password;
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
        _userId = -1;
    }
    public User(string firstName, string lastName, string email, string phoneNum, string address, string birthDate, string password, int userId)
    {
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _phoneNum = phoneNum;
        _address = address;
        _birthDate = birthDate;
        _password = password;
        _userId = userId;
    }

    public void SetFirstName(string first)
    {
        _firstName = first;
    }

    public void SetLastName(string last)
    {
        _lastName = last;
    }

    public void SetPhoneNum(string num)
    {
        _phoneNum = num;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }

    public void SetBirthDate(string bday)
    {
        _birthDate = bday;
    }

    public void SetPassword(string pass)
    {
        _password = pass;
    }

    public void SetId(int id)
    {
        _userId = id;
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

    public int GenerateUniqueId()
    {
        throw new NotImplementedException();
    }
}