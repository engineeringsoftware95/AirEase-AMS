using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Ticket;

public class Ticket : ITicket
{


    private double _straightLineMileage;
    private double _ticketCost;
    private string _ticketId;
    private List<Flight> flights;

    public Ticket(int straightLineMileage, double ticketCost, string ticketId)
    {
        _straightLineMileage = straightLineMileage;
        _ticketCost = ticketCost;
        _ticketId = ticketId;
    }


    public double CalculateStraightLineMileage()
    {
        double mileage = 0;
        foreach (Flight f in flights)
        {
           mileage += f.GetDistance();
        }

        return mileage;
    }


    public double CalculateTicketCost()
    {
        double runningTotal = 0;

        runningTotal = CalculateStraightLineMileage() * .12;
        runningTotal += 50;
        runningTotal += (8 * flights.Count);
        TimeSpan departureTime = flights[0].GetTime().TimeOfDay;
       
        // this needs to be estimated arrival time, not departure time.
        TimeSpan finalArrival = flights.Last().GetTime().TimeOfDay;
        if (departureTime.Hours is >= 0 and <= 5)
        {
            runningTotal *= .8;
        }
        else if(departureTime.Hours <= 8 || finalArrival.Hours >= 19)
        {
            runningTotal *= .9;
        }
        return runningTotal;
    }


}