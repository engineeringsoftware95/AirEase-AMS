using AirEase_AMS.App.Defs.Struct;
using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Defs;

public interface IRoute
{
    bool FlightExists(IRoute flight);
    int GetDistance();
    IGraphNode Origin();
    IGraphNode Destination();
    List<Flight>? FindFlightsInRange(DateTime begin, DateTime end);
    bool IsDestination(string city);
    bool IsOrigin(string city);
    DateTime GetTime();
}