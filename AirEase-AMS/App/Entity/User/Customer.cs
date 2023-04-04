using AirEase_AMS.App.Defs;

namespace AirEase_AMS.App.Entity.User;

public class Customer : User
{
    public Customer()
    {
      SetRole(1);
    }
}