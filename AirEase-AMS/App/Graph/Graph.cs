using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;
using AirEase_AMS.App.Graph.Flight;
// ReSharper disable All
namespace AirEase_AMS.App.Graph;

public class Graph : IGraph
{
    private List<IGraphNode> _airports;
    private List<string> _cityNames;
    


    public IRoute? FindFlight(string origin, string destination)
    {
        // Graph contains a list of airports.
        // Each airport contains a list of routes.
        // Each route contains a list of flights.
        // to find flights:
        //
        // Check if origin and destination are in the graph.
        // If not, return an error and exit.
        //
        // Search origin city's routes list.
        // If destination city is not there, return an error and exit.
        // Return the route.
        if (!_cityNames.Contains(origin) || !_cityNames.Contains(destination))
        {
            return null;
        }
        foreach (var airport in _airports)
        {
            if (!airport.GetCityName().Equals(origin)) continue;
            foreach (var route in airport.GetRoutes()!)
            {
                if (route.IsDestination(destination))
                {
                    return route;
                }
            }
        }
        return null;
    }

    public List<IFlight>? GetFlightsInRange(string origin, string destination, DateTime begin, DateTime end)
    {
        List<IFlight>? validFlights = null;
        IRoute? route = FindFlight(origin, destination);
        validFlights = route?.FindFlightsInRange(begin, end);
        return validFlights;
    }
}