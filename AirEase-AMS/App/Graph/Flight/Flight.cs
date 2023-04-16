using AirEase_AMS.App.Entity.Aircraft;
using System.Data;

namespace AirEase_AMS.App.Graph.Flight;

public class Flight : Route
{
    private readonly DateTime _flightTime;
    private readonly Aircraft _aircraft;
    private string _flightID;
    private string _yearWeekId;

    public Flight(string flightId, string departureId) : base(flightId, departureId)
    {
        _flightID = flightId;
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


        }

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