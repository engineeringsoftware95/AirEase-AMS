namespace AirEase_AMS.App.Entity.User.Employees;

public class FlightManager : User
{
    private int _roleBit = 3;
    public FlightManager()
    {
        SetRole(3);
    }
}