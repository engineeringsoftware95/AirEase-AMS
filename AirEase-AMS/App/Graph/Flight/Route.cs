using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;
using System.Data;

namespace AirEase_AMS.App.Graph.Flight;

public class Route : IRoute, IComparable<Route>
{
    protected IGraphNode _origin;
    protected IGraphNode _destination;
    protected List<IRoute> _flightsOnRoute;
    protected int _distance;
    protected string _routeId;

    public Route(string flightId, string departureId)
    {
        

    }

    public Route(string routeId)
    {

    }

    public bool FlightExists(IRoute flight)
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
    public List<Flight>? FindFlightsInRange(DateTime begin, DateTime end)
    {
        List<Flight>? validFlights = null;
        foreach(var route in _flightsOnRoute)
        {
            var flight = (Flight)route;
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

    public DateTime GetTime()
    {
        throw new NotImplementedException();
    }


    public int GetDistance()
    {
        return _distance;
    }
    
    public int CompareTo(Route? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return GetDistance().CompareTo(other.GetDistance());
    }
    
    
    public static int CompareByDistance(Flight? lhs, Flight? rhs)
    {
        if ((lhs == null))
        {
            if (rhs == null) // if lhs and rhs are null, they are equal
            {
                return 0; // so return 0.
            }

            return -1; // If lhs is null and rhs is not, then lhs < rhs.
        }

        if (rhs == null) // likewise, if we get here, lhs is not null, so lhs > rhs
        {
            return 1;
        }
        // otherwise compare the values.
        int retval = lhs.GetDistance().CompareTo(rhs.GetDistance());
        return retval != 0 ? retval : lhs.CompareTo(rhs);
    }


    public string RouteId()
    {
        return _routeId;
    }


    public void GenerateId()
    {
        _routeId = HLib.GenerateSixDigitId().ToString();
    }
    
}