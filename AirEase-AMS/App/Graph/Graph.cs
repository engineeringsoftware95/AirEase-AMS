using System.ComponentModel;
using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;
using AirEase_AMS.App.Graph.Flight;
using Microsoft.IdentityModel.Tokens;

// ReSharper disable All
namespace AirEase_AMS.App.Graph;

public class Graph : IGraph
{
    private List<IGraphNode>? _airports;

    public Graph()
    {
        _airports = new List<IGraphNode>();
    }

    public void add_node(Airport airport)
    {
        _airports?.Add(airport);
    }
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
        if (_airports != null)
            foreach (var airport in _airports)
            {
                if (!airport.GetCityName().Equals(origin)) continue;
                foreach (var route in airport.DepartingFlights()!)
                {
                    if (route.IsDestination(destination))
                    {
                        return route;
                    }
                }
            }

        return null;
    }

    public List<Flight.Flight>? GetFlightsInRange(string origin, string destination, DateTime begin,
        DateTime end)
    {
        List<Flight.Flight>? validFlights = new List<Flight.Flight>();
        IRoute? route = FindFlight(origin, destination);
        validFlights = route?.FindFlightsInRange(begin, end);
        validFlights?.Sort();
        return validFlights;
    }
}