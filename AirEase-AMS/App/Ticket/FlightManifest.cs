using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Ticket;

public class FlightManifest
{
    private List<Customer> _passengers;
    private Flight _flight;
    private string manifest;

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
    
}