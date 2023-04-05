using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;

namespace AirEase_AMS.App.Graph.Flight;

public class Route : IRoute
{
    private IGraphNode _origin;
    private IGraphNode _destination;
    private List<IFlight> _flightsOnRoute;


    public bool FlightExists(IFlight flight)
    {
        return _flightsOnRoute.Contains(flight);
    }

    /*
     * Find flights before
     * Given a DateTime object, populate a list of flights which
     * depart before or exactly on the date in question.
     * By feeding a DateTime object to this method, we can set the
     * search for flights for hours, days, months, etc. with a single function,
     * which are before a certain departure time.
     */
    public List<IFlight>? FindFlightsInRange(DateTime begin, DateTime end)
    {
        List<IFlight>? validFlights = null;
        foreach(var flight in _flightsOnRoute)
        {
            if (DateTime.Compare(flight.GetTime(), end) <= 0)
            {
                if (DateTime.Compare(flight.GetTime(), begin) >= 0)
                {
                    validFlights?.Add(flight);
                }
            }
        }
        return validFlights;
    }

    public IGraphNode Origin()
    {
        return _origin;
    }

    public IGraphNode Destination()
    {
        return _destination;
    }

    public bool IsDestination(string city)
    {
        return _destination.GetCityName().Equals(city);
    }
    
    public bool IsOrigin(string city)
    {
        return _origin.GetCityName().Equals(city);
    }
}