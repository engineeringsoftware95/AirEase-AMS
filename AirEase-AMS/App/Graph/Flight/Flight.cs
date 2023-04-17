using AirEase_AMS.App.Entity.Aircraft;
using System.Data;

namespace AirEase_AMS.App.Graph.Flight;

public class Flight : Route
{
    private readonly DateTime _flightTime;
    private readonly Aircraft _aircraft;
    private string _flightId;
    private string _yearWeekId;

    /// <summary>
    /// Takes a flight and departure key, uses them to load this instance with data with identical keys in the database.
    /// </summary>
    /// <param name="flightId">The key used to identify the correct flight information.</param>
    /// <param name="departureId">The key used to identify the correct departure information.</param>
    public Flight(string flightId, string departureId)
    {
        _flightId = flightId;
        DatabaseAccessObject dao = new DatabaseAccessObject();

        string query = String.Format("EXEC GetAllFlightInformation @DepartureID = {0}, @FlightID = {1};", departureId, flightId);
        System.Data.DataTable dt = dao.Retrieve(query);
        if(dt == null  || dt.Rows.Count != 1)
        {
            _flightTime = DateTime.UnixEpoch;
            _aircraft= new Aircraft("-1");
            _yearWeekId = "-1";
        }
        else
        {
            DataRow flight = dt.Rows[0];
            _yearWeekId = flight["YearWeekID"].ToString() ?? "-1";
            _flightTime = DateTime.Parse(flight["DepartureTime"].ToString() ?? "-1");
            //WORK IN PROGRESS
            _aircraft = new Aircraft(flight["PlaneID"].ToString() ?? "-1");
            _routeId = flight["RouteID"].ToString() ?? "-1";
            query = String.Format("SELECT * FROM FLIGHTROUTE WHERE RouteID = {0}", _routeId);
            System.Data.DataTable routeTable = dao.Retrieve(query);
            if (routeTable == null || routeTable.Rows.Count != 1)
            {
                _routeId = "-1";
                _origin = new Airport("-1");
                _destination = new Airport("-1");
                _flightsOnRoute = new List<Flight>();
            }
            else
            {
                DataRow route = routeTable.Rows[0];
                _origin = new Airport(route["OriginAirportID"].ToString() ?? "-1");
                _destination = new Airport(route["DestinationAirportID"].ToString() ?? "-1");
                _flightsOnRoute = new List<Flight>();
            }

        }

    }

    public Flight(string routeId, string yearWeekId, DateTime departureTime, string planeId) : base(routeId)
    {
        _yearWeekId = yearWeekId;
        _flightTime = departureTime;
        _flightId = GenerateId();
        _routeId = routeId;
        _aircraft = new Aircraft(planeId);
    }

    public bool UploadFlight()
    {
        DatabaseAccessObject dao = new DatabaseAccessObject();
        //While the ID isn't unique, make a new one.
        _routeId = (GenerateId());
        while (dao.Retrieve("SELECT * FROM FLIGHT WHERE FlightID=" + _flightId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _flightId = (GenerateId());
        }
        string query = String.Format("INSERT INTO FLIGHTROUTE VALUES({0}, {1}, {2}, {3})", _routeId, _origin.GetAirportId(), _destination.GetAirportId(), _distance);
        return (dao.Update(query) == 1);
    }

    public DateTime GetTime()
    {
        return _flightTime;
    }

    public bool Equals(Flight? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _flightTime.Equals(other._flightTime)
               && _aircraft.Equals(other._aircraft)
               && Origin().Equals(other.Origin())
               && Destination().Equals(other.Destination());
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Flight)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_flightTime, _aircraft);
    }

    public DateTime EstimateArrivalTime()
    {
        DateTime estimate = new DateTime();

        return estimate;
    }

    public string GetFlightId()
    {
        return _flightID;
    }
}