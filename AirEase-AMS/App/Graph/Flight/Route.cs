using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Windows.Forms;

namespace AirEase_AMS.App.Graph.Flight;

public class Route : IRoute, IComparable<Route>
{
    protected IGraphNode _origin;
    protected IGraphNode _destination;
    protected List<Flight> _flightsOnRoute;
    protected double _distance;
    protected string _routeId;


    //Base constructor used for child class flight
    public Route()
    {
        _destination = new Airport();
        _origin = new Airport();
        _flightsOnRoute = new List<Flight>();
    }


    /// <summary>
    /// Takes a route ID and instantiates this class with the route with routeID from the database.
    /// </summary>
    /// <param name="routeId">The key associated with the route we want.</param>
    public Route(string routeId)
    {//TODO: statement or branch uncovered
        DatabaseAccessObject dao = new DatabaseAccessObject();

        _routeId = routeId;
        string query = String.Format("SELECT * FROM FLIGHTROUTE WHERE RouteID = {0}", _routeId);
        System.Data.DataTable routeTable = dao.Retrieve(query);
        if (routeTable == null || routeTable.Rows.Count < 1)
        {
            _routeId = "";
            _origin = new Airport("-1");

            _destination = new Airport("-1");
            _flightsOnRoute = new List<Flight>();
            _distance = 0;
        }//TODO: statement or branch uncovered
        else
        {//TODO: statement or branch uncovered
            DataRow route = routeTable.Rows[0];
            _routeId = routeId;
            _origin = new Airport(route["OriginAirportID"].ToString() ?? "-1");
            _destination = new Airport(route["DestinationAirportID"].ToString() ?? "-1");
            _flightsOnRoute = new List<Flight>();
            _distance = double.Parse(route["DistanceMiles"].ToString() ?? "-1");
        }//TODO: statement or branch uncovered
    }

    public Route(string originAirportId, string destinationAirportId, int distanceMiles)
    {
        _routeId = GenerateId();
        _origin = new Airport(originAirportId);
        _destination = new Airport(destinationAirportId);
        _distance = distanceMiles;
        _flightsOnRoute= new List<Flight>();
    }

    public bool UploadRoute()
    {
        DatabaseAccessObject dao = new DatabaseAccessObject();

        //While the ID isn't unique, make a new one.
        _routeId = (GenerateId());
        while (dao.Retrieve("SELECT * FROM FLIGHTROUTE WHERE RouteID=" + _routeId + ";").Rows.Count > 0)
        {//TODO: statement or branch uncovered
            //Set ID until one is unique
            _routeId = (GenerateId());
        }

        if (_origin.GetAirportId().Length < 6 || _destination.GetAirportId().Length < 6) return false;

        string query = String.Format("INSERT INTO FLIGHTROUTE VALUES({0}, {1}, {2}, {3});", _routeId, _origin.GetAirportId(), _destination.GetAirportId(), _distance);
        return (dao.Update(query) >= 1);
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
        List<Flight>? validFlights = new List<Flight>();
        foreach(var route in _flightsOnRoute)
        {
            if ((DateTime.Compare(route.GetTime(), begin) >= 0) && (DateTime.Compare(route.GetTime(), end) <= 0))
            {
                    validFlights?.Add(route);
            }
        }
        return validFlights;
    }

    public string GetOriginCity() { return _origin.GetCityName();  }
    public string GetDestinationCity() {  return _destination.GetCityName(); }  

    public IGraphNode Origin()
    {//TODO: statement or branch uncovered
        return _origin;
    }

    public IGraphNode Destination()
    {//TODO: statement or branch uncovered
        return _destination;
    }
    

    public bool IsDestination(string city)
    {
        return _destination.GetCityName().Equals(city);
    }
    
    public bool IsOrigin(string city)
    {//TODO: statement or branch uncovered
        return _origin.GetCityName().Equals(city);
    }

    public DateTime GetTime()
    {//TODO: statement or branch uncovered
        throw new NotImplementedException();
    }

    public void AddFlight(Flight flight)
    {
        _flightsOnRoute.Add(flight);
    }
    public double GetDistance()
    {//TODO: statement or branch uncovered
        return _distance;
    }

    public string GetRouteId() { return _routeId; } //TODO: statement or branch uncovered
    
    public int CompareTo(Route? other)
    {//TODO: statement or branch uncovered
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return GetDistance().CompareTo(other.GetDistance());
    }
    
    
    public static int CompareByDistance(Flight? lhs, Flight? rhs)
    {//TODO: statement or branch uncovered
        if ((lhs == null))
        {
            if (rhs == null) // if lhs and rhs are null, they are equal
            {
                return 0; // so return 0.
            }

            return -1; // If lhs is null and rhs is not, then lhs < rhs.
        }
        //TODO: statement or branch uncovered
        if (rhs == null) // likewise, if we get here, lhs is not null, so lhs > rhs
        {
            return 1;
        }
        // otherwise compare the values.
        int retval = lhs.GetDistance().CompareTo(rhs.GetDistance());//TODO: statement or branch uncovered
        return retval != 0 ? retval : lhs.CompareTo(rhs);
    }

    public string GenerateId()
    {
        return HLib.GenerateSixDigitId().ToString();
    }
    public void SetOrigin(string origin)
    {
        _origin.SetCity(origin);
    }

    public void SetDestination(string destination)
    {
        _destination.SetCity(destination);
    }
}