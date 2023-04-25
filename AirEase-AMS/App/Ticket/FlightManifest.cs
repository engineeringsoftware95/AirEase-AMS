using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Graph.Flight;
using System.Data;

namespace AirEase_AMS.App.Ticket;

public class FlightManifest
{
    private List<Customer> _passengers;
    private Flight _flight;
    private string _manifest;
    private string _flightId;
    private string _departureId;

    public FlightManifest(string flightId, string departureId)
    {
        _flightId = flightId;
        _departureId= departureId;
        _flight = new Flight(flightId, departureId);
        _passengers = new List<Customer>();
        _manifest = "";
        string query = String.Format("EXEC GetAllCustomerFlights @FlightID = {0}, @DepartureID = {1};", flightId, departureId);
        DatabaseAccessObject dao = new DatabaseAccessObject();
        DataTable dt = dao.Retrieve(query);
        //Add each customer associated with the flight to the _passengers list
        foreach (DataRow row in dt.Rows)
        {
            _passengers.Add(new Customer(row["UserID"].ToString() ?? ""));
        }
    }

    public string GetFlightManifest()
    {
        return _manifest;
    }


    public void PopulateManifest()
    {
        _manifest = _flight.GetFlightId();
        foreach(Customer c in _passengers)
        {
            _manifest += ",";
            _manifest += c.GetFirstName();
            _manifest += ",";
            _manifest += c.GetLastName();
            _manifest += ",";
            _manifest += c.GetUserId();
        }
    }

    public int PassengersOnFlightCount()
    {
        return _passengers.Count;
    }
}