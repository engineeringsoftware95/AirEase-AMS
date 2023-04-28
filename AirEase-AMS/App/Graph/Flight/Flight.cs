using AirEase_AMS.App.Entity.Aircraft;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace AirEase_AMS.App.Graph.Flight;


//We need a function to get the number of people on any given flight in the flight class. Number of people on flight needs to be a member variable

public class Flight : Route
{
    readonly DateTime _flightTime;
    private Aircraft _aircraft;
    private string _flightId;
    private string _yearWeekId;
    private decimal _flightCost;
    private int _flightPoints;
    private string _departureId;
    private int _peopleOnFlight;

    /// <summary>
    /// Takes a flight and departure key, uses them to load this instance with data with identical keys in the database.
    /// </summary>
    /// <param name="flightId">The key used to identify the correct flight information.</param>
    /// <param name="departureId">The key used to identify the correct departure information.</param>
    public Flight(string flightId, string departureId)
    {
        _flightId = flightId;
        _departureId= departureId;

        string query = String.Format("EXEC GetAllCustomerFlights @FlightID = {0}, @DepartureID = {1};", flightId, departureId);
        DatabaseAccessObject dao = new DatabaseAccessObject();
        DataTable flightsTable = dao.Retrieve(query);
        _peopleOnFlight = flightsTable.Rows.Count;


        query = String.Format("EXEC GetAllFlightInformation @DepartureID = {0}, @FlightID = {1};", departureId, flightId);
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
            _flightTime = DateTime.Parse(flight["DepartureTime"].ToString() ?? "");
            _aircraft = new Aircraft(flight["PlaneID"].ToString() ?? "-1");
            _routeId = flight["RouteID"].ToString() ?? "-1";

            query = String.Format("SELECT * FROM FLIGHTROUTE WHERE RouteID = {0};", _routeId);
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
                _distance = double.Parse(route["DistanceMiles"].ToString() ?? "-1");
            }
        }
        _flightCost = CalculateFlightCost();
        _flightPoints = CalculateFlightPoints();

    }//TODO: statement or branch uncovered

    public Flight(string routeId, string yearWeekId, DateTime departureTime) : base(routeId)
    {//TODO: statement or branch uncovered
        _yearWeekId = yearWeekId;
        _flightTime = departureTime;
        _flightId = GenerateId();

        //Use the default aircraft ID
        _aircraft = new Aircraft("111111");
        _flightCost = CalculateFlightCost();
        _flightPoints = CalculateFlightPoints();
        _departureId = HLib.GenerateSixDigitId().ToString();
    }

    public Flight()
    {
    }

    public Flight(Airport testOrigin, Airport destination, DateTime departureTime)
    {
        _origin = testOrigin;
        _destination = destination;
        _flightTime = departureTime;
    }

    public bool UploadFlight()
    {//TODO: statement or branch uncovered
        DatabaseAccessObject dao = new DatabaseAccessObject();

        //While the ID isn't unique, make a new one.
        _flightId = (GenerateId());
        while (dao.Retrieve("SELECT * FROM FLIGHT WHERE FlightID=" + _flightId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _flightId = (GenerateId());
        }

        //While the ID isn't unique, make a new one.
        _departureId = (GenerateId());
        while (dao.Retrieve("SELECT * FROM DEPARTURES WHERE DepartureID=" + _departureId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _departureId = (GenerateId());
        }

        string query = String.Format("EXEC InsertFlight @FlightID = {0}, @FlightCost = {1}, @FlightPoints = {2}, @RouteID = {3}, @DepartureID = {4}, @YearWeekID = {5}, @DepartureTime = '{6}', @PlaneID = {7};", 
            _flightId, _flightCost, _flightPoints, _routeId,
            _departureId, _yearWeekId, _flightTime.TimeOfDay.ToString(), _aircraft.GetAircraftId());

        return (dao.Update(query) >= 1);
    }

    public bool SetPlaneForFlight(string aircraftId)
    {
        _aircraft = new Aircraft(aircraftId);
        DatabaseAccessObject dao = new DatabaseAccessObject();
        string query = String.Format("UPDATE FLIGHT_PLANE SET PlaneID = {0} WHERE FlightID = {1};", aircraftId, _flightId);
        return (dao.Update(query) == 1);
    }

    public string GetDepartureId() {  return _departureId; }//TODO: statement or branch uncovered


    public DateTime GetTime()
    {
        return _flightTime;
    }

    public bool Equals(Flight? other)
    {//TODO: statement or branch uncovered
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
        if (obj.GetType() != this.GetType()) return false;//TODO: statement or branch uncovered
        return Equals((Flight)obj);
    }

    public override int GetHashCode()
    {//TODO: statement or branch uncovered
        return HashCode.Combine(_flightTime, _aircraft);
    }

    public DateTime EstimateArrivalTime()
    {//TODO: statement or branch uncovered
        DateTime arrivalTime = _flightTime.AddHours((_distance / 500.0) + 0.5);
        return arrivalTime;
    }

    public string GetFlightId()
    {//TODO: statement or branch uncovered
        return _flightId;
    }


    public decimal CalculateFlightCost()
    {//TODO: statement or branch uncovered
       //Calculates the cost of an individual flight
       if (_distance == 0) return 0;
       
        double runningTotal = _distance * .12;
        runningTotal += 50;
        TimeSpan departureTime = _flightTime.TimeOfDay;
        TimeSpan finalArrival = EstimateArrivalTime().TimeOfDay;
        if (departureTime.Hours is >= 0 and <= 5)
        {//TODO: statement or branch uncovered
            runningTotal *= .8;
        }
        else if (departureTime.Hours <= 8 || finalArrival.Hours >= 19)
        {//TODO: statement or branch uncovered
            runningTotal *= .9;
        }//TODO: statement or branch uncovered
        return Convert.ToDecimal(runningTotal);
    }

    public decimal GetFlightCost()
    {//TODO: statement or branch uncovered
        return _flightCost;
    }

    private int CalculateFlightPoints()
    {//TODO: statement or branch uncovered
        return HLib.ConvertToPoints(_flightCost);
    }

    public string GetAircraftID()
    {
        return _aircraft.GetAircraftId();
    }

    public int GetSeats()
    {
        return _aircraft.GetNumberOfSeats();
    }


    public int GetSeatsTaken() { return _peopleOnFlight; }

}