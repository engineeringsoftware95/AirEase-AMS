using AirEase_AMS.App.Entity.Aircraft;

namespace AirEase_AMS.App.Graph.Flight;

public class Flight : Route
{
    private DateTime _flightTime;
    private Aircraft _aircraft;



    public DateTime GetTime()
    {
        return _flightTime;
    }
}