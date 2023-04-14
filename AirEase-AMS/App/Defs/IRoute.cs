using AirEase_AMS.App.Defs.Struct;

namespace AirEase_AMS.App.Defs;

public interface IRoute
{
    public bool FlightExists(IFlight flight);
    int GetDistance();
    public IGraphNode Origin();
    public IGraphNode Destination();
    public List<IFlight>? FindFlightsInRange(DateTime begin, DateTime end);
    public bool IsDestination(string city);
    public bool IsOrigin(string city);
}