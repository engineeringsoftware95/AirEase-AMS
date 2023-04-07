namespace AirEase_AMS.App.Defs;

public interface IUser
{
    void SetFirstName(string first);
    void SetLastName(string last);
    void SetPhoneNum(string num);
    void SetEmail(string email);
    void SetBirthDate(string bday);
    void SetPassword(string pass);
    void SetId(int id);

    string GetFirstName();
    string GetLastName();
    string GetEmail();
    string GetPassword();
    string GetPhoneNum();
    string GetBirthDate();
    int GetUserId();
    int GenerateUniqueId();
    bool AttemptLogin(string username, string password);

}