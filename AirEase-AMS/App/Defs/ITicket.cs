using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Defs;

public interface ITicket
{
    public void AddFlight(Flight flight);

    public int GenerateTicketId();

    public string GetTicketInformation();

    public bool PurchaseTicket();

    public bool CancelTicket();
}