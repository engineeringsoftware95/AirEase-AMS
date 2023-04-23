using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Graph.Flight;
using System.Data;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace AirEase_AMS.App.Ticket;

public class Ticket : ITicket
{


    private double _straightLineMileage;
    private decimal _ticketCost;
    private string _ticketId;
    private string _startCity;
    private string _endCity;
    private bool _isRefunded;
    private string _transactionId;
    private string _customerId;

    private List<Flight> flights;

    public Ticket(decimal ticketCost, string startCity, string endCity, string customerId)
    {
        _straightLineMileage = 0;
        _ticketCost = ticketCost;
        _ticketId = GenerateTicketId().ToString();
        _startCity = startCity;
        _endCity = endCity;
        _isRefunded = false;
        flights = new List<Flight>();
        _transactionId = HLib.GenerateSixDigitId().ToString();
        _customerId = customerId;
    }

    public Ticket(string ticketId)
    {
        _ticketId = ticketId;
        //Selecting for primary key - the result should ALWAYS be one ticket
        string query = "SELECT * FROM TICKETS WHERE TicketID = " + ticketId + ";";
        DatabaseAccessObject dao = new DatabaseAccessObject();
        DataTable dt = dao.Retrieve(query);

        //Invalid read
        if(dt == null || dt.Rows.Count != 1) 
        {
            _straightLineMileage = 0;
            _ticketCost = 0;
            _startCity= string.Empty;
            _endCity= string.Empty;
            _isRefunded = false;
        }
        else
        {
            DataRow ticket = dt.Rows[0];

            //Set argument to -1 if ticket returns null
            _straightLineMileage = double.Parse(ticket["DistanceMiles"].ToString() ?? "-1");
            _ticketCost = decimal.Parse(ticket["TicketCost"].ToString() ?? "-1");

            //Return empty string on invalid read
            _startCity = ticket["StartCity"].ToString() ?? "";
            _endCity = ticket["EndCity"].ToString() ?? "";
        }

        flights = new List<Flight>();
    }

    public bool UploadTicket()
    {
        DatabaseAccessObject dao = new DatabaseAccessObject();
        //While the ID isn't unique, make a new one.
        _transactionId = (GenerateTicketId());
        while (dao.Retrieve("SELECT * FROM TRANSACTION WHERE TransactionID=" + _transactionId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _ticketId = (GenerateTicketId());
        }

        //While the ID isn't unique, make a new one.
        _ticketId = (GenerateTicketId());
        while (dao.Retrieve("SELECT * FROM TICKETS WHERE TicketID=" + _ticketId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _ticketId = (GenerateTicketId());
        }

        string query = String.Format("EXEC InsertTicket " +
            "@TicketID = {0}, @StartCity = '{1}', @EndCity  = '{2}', @TicketCost = {3}, " +
            "@DistanceMiles  = {4}, @TransactionID  = {5}, @CustomerID  = {6}, @PointCost  = {7};", 
            _ticketId, _startCity, _endCity, _ticketCost, _straightLineMileage, _transactionId,_customerId, HLib.ConvertToPoints(_ticketCost));

        foreach(Flight flight in flights)
        {
            query = String.Format("EXEC UpdateFlights " +
            "@CustomerID = {0}, @FlightID = {1}, @DepartureID = {2}, @TicketID = {3};", _customerId, flight.GetFlightId(), flight.GetDepartureId(), _ticketId);
        }

        return (dao.Update(query) == 1);
    }

    public void SetStraightLineMileage(double slm)
    {
        _straightLineMileage = slm;
    }

    public double GetStraightLineMileage() { return _straightLineMileage; }

    public decimal GetTicketCost() { return _ticketCost; }

    public string GetTicketId()
    {
        return _ticketId;
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
        //Summates the cost of all flights in this ticket, then adds layover costs.
        return Convert.ToDouble(flights[0].GetFlightCost() + ((flights.Count-1)*8));
    }

    public void AddFlight(Flight flight) //TODO: statement uncovered - needs test  
    {
        if(flights.Count <= 3)
            flights.Add(flight);
    }

    public string GenerateTicketId()
    {
       return HLib.GenerateSixDigitId().ToString(); //TODO: statement uncovered - needs test  
    }

    public string GetTicketInformation() //TODO: statement uncovered - needs test  
    {
        //Don't argue with me.
        string output = ""; 

        output += String.Format("Ticket ID: ${0}\n", _ticketId);
        output += String.Format("Customer ID: ${0}\n", _customerId);
        output += String.Format("Flight from {0} to {1}\n", _startCity, _endCity);
        output += String.Format("Distance: {0} miles\n", _straightLineMileage.ToString());

        for (int i = 1; i < flights.Count; i++)
        {
            output += String.Format("Layover from: ${0}  to: {1} \n", flights[i].Origin(), flights[i].Destination());
        }

        output += String.Format("Invoice Number: ${0}\n", _transactionId);
        output += String.Format("Total cost: ${0}\n", _ticketCost.ToString());
        return output;
    }

    /// <summary>
    /// Attempts to insert this ticket into the database.
    /// </summary>
    /// <returns>Whether or not the ticket was successfully inserted.</returns>
    public bool PurchaseTicket() //TODO: statement uncovered - needs test  
    {
        DatabaseAccessObject dao = new DatabaseAccessObject();

        //While the ID isn't unique, make a new one.
        _ticketId = GenerateTicketId().ToString();
        while (dao.Retrieve("SELECT * FROM TICKETS WHERE TicketID=" + _ticketId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _ticketId = GenerateTicketId().ToString();
        }


        //Create query - isRefunded is always defaulted to zero when purchasing a ticket - because why would you refund a ticket while buying it.
        string query = "INSERT INTO TICKETS VALUES(" + _ticketId + ", '" + _startCity + "', '" + _endCity + "', " + _ticketCost + ", " + _straightLineMileage + ", 0);";

        //Number of rows altered should equal one on a successful insert
        bool ticketInserted = dao.Update(query) == 1;

        //If we already failed to insert the ticket, do not try to insert the ticket_flight relation.
        if(!ticketInserted) { return false; }

        //Insert each flight-ticket relation, if any one of them is false the whole thing fails.
        bool flightRelationsInserted = true;
        foreach (Flight flight in flights)
        {
            query = "INSERT INTO TICKETS_FLIGHT VALUES(" + _ticketId + ", " + flight.GetFlightId() + ");";
            flightRelationsInserted = dao.Update(query) == 1;

            //If one of the inserts fail, break out. Don't keep trying.
            if (!flightRelationsInserted) break;
        }

        return flightRelationsInserted;
        
    }

    /// <summary>
    /// Attempts to cancel the ticket with this class' TicketID.
    /// </summary>
    /// <returns>Whether or not the ticket was successfully cancelled.</returns>
    public bool CancelTicket() //TODO: statement uncovered - needs test  
    {
        DatabaseAccessObject dao = new DatabaseAccessObject();
        string query = "UPDATE TICKETS SET IsRefunded = 1 WHERE TicketID = " + _ticketId + ";";

        //Should alter one row by changing its IsRefunded attribute
        return dao.Update(query) == 1;
    }

}