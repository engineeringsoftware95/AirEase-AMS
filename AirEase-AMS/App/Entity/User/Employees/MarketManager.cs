namespace AirEase_AMS.App.Entity.User.Employees;

public class MarketManager : User
{
    private int _roleBit = 5;
    public MarketManager()
    {
        SetRole(4);
    }
}