using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Ticket;

public class FlightManifest
{
    private List<Customer> _passengers;
    private Flight _flight;
    private string manifest;


    public FlightManifest()
    {
        _passengers = new List<Customer>();
        _flight = new Flight();
    }
    public string GetFlightManifest()
    {
        return manifest;
    }


    public void PopulateManifest()
    {
        manifest = _flight.GetFlightId();
        foreach(Customer c in _passengers)
        {
            manifest += ",";
            manifest += c.GetFirstName();
            manifest += ",";
            manifest += c.GetLastName();
            manifest += ",";
            manifest += c.GetUserId();
        }
    }
    
    public void SetFlight(Flight t)
    {
        _flight = t;
    }

    public Flight GetFlight()
    {
        return _flight;
    }


    public List<Customer> GetPassengerList()
    {
        return GetPassengerList();
    }

    public void AddCustomer(Customer c)
    {
        _passengers.Add(c);
    }
    
    
}