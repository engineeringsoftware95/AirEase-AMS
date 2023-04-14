using AirEase_AMS.App.Defs;

namespace AirEase_AMS.App.Entity.User;

public class Customer : User
{
    public Customer(string fName, string lName, string address, string date, string password, string phoneNum, string email)
    {
        SetRole(1);
        SetFirstName(fName);
        SetLastName(lName);
        SetAddress(address);
        SetBirthDate(date);
        SetSalt(HLib.GenerateSalt(32));
        SetPassword(HLib.EncryptPassword(password, GetSalt()));
        SetPhoneNum(phoneNum);
        SetEmail(email);
        SetId(GenerateId());
    }


}