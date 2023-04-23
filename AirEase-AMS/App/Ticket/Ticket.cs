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
    private string? _customerId;
    private AirEase_AMS.Transaction.Transaction? _transaction;

    private List<Flight> flights;

    /// <summary>
    /// This constructor is designed to instantiate a new ticket.
    /// </summary>
    /// <param name="ticketCost">The total currency cost of the ticket.</param>
    /// <param name="startCity">The origin city.</param>
    /// <param name="endCity">The destination city.</param>
    /// <param name="customerId">The ID of the purchasing customer.</param>
    public Ticket(decimal ticketCost, string startCity, string endCity, string customerId, bool pointsUsed)
    {
        _straightLineMileage = 0;
        _ticketCost = ticketCost;
        _ticketId = GenerateTicketId().ToString();
        _startCity = startCity;
        _endCity = endCity;
        _isRefunded = false;
        flights = new List<Flight>();
        _customerId = customerId;

        //Only one of these can have a value. If points were used, we put the cost in points and zero dollars in currency cost.
        _transaction = new AirEase_AMS.Transaction.Transaction(pointsUsed ? 0 : ticketCost, pointsUsed ? HLib.ConvertToPoints(ticketCost) : 0, customerId);
    }

    /// <summary>
    /// This constructor is designed to instantiate an existing ticket.
    /// </summary>
    /// <param name="ticketId">The ticket we want to search for.</param>
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
            _isRefunded = int.Parse(ticket["IsRefunded"].ToString() ?? "-1") > 0;
        }
        flights = new List<Flight>();
    }

    /// <summary>
    /// Attempts to upload this ticket class to the database.
    /// </summary>
    /// <returns>Whether or not the function succeeded.</returns>
    public bool UploadTicket()
    {
        //If flights is empty or transaction is null, return false.
        if (flights.Count == 0) return false;

        if (_transaction != null) _transaction.UploadTransaction();
        else return false;

        DatabaseAccessObject dao = new DatabaseAccessObject();

        //While the ID isn't unique, make a new one.
        _ticketId = (GenerateTicketId());
        while (dao.Retrieve("SELECT * FROM TICKETS WHERE TicketID=" + _ticketId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _ticketId = (GenerateTicketId());
        }

        //Stored procedure for ticket insertion
        string query = String.Format("EXEC InsertTicket " +
            "@TicketID = {0}, @StartCity = '{1}', @EndCity  = '{2}', @TicketCost = {3}, " +
            "@DistanceMiles  = {4}, @TransactionID  = {5}, @CustomerID  = {6};", 
            _ticketId, _startCity, _endCity, _ticketCost, _straightLineMileage, _transaction._transactionId,_customerId);

        bool firstQuery = (dao.Update(query) > 0);

        //For each flight in flights, update the tables in the database using a stored procedure.
        foreach(Flight flight in flights)
        {
            query = String.Format("EXEC UpdateFlights " +
            "@CustomerID = {0}, @FlightID = {1}, @DepartureID = {2}, @TicketID = {3};", _customerId, flight.GetFlightId(), flight.GetDepartureId(), _ticketId);
        }

        //If both queries succeeded, return true.
        return (dao.Update(query) > 0) && firstQuery;
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

    public bool IsRefunded() { return _isRefunded; }


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

    public void AddFlight(Flight flight)
    {
        if(flights.Count <= 3)
            flights.Add(flight);
    }

    public string GenerateTicketId()
    {
       return HLib.GenerateSixDigitId().ToString();
    }

    public string GetTicketInformation()
    {
        //THIS IS A STUB - IT ISNT FINISHED!
        string output = "";

        output += String.Format("Flight from {0} to {1}\n", _startCity, _endCity);
        output += String.Format("Distance: {0} miles\n", _straightLineMileage);
        output += String.Format("Cost: ${0}\n", _ticketCost);

        return output;
    }


    /// <summary>
    /// Attempts to cancel the ticket with this class' TicketID.
    /// </summary>
    /// <returns>Whether or not the ticket was successfully cancelled.</returns>
    public bool CancelTicket()
    {
        _isRefunded = true;
        int pointsCost;
        if (_transaction == null) pointsCost = 0;
        else pointsCost = _transaction._pointCost;

        decimal currencyCost;
        if (_transaction == null) currencyCost = 0;
        else currencyCost = _transaction._currencyCost;

        DatabaseAccessObject dao = new DatabaseAccessObject();
        string query = String.Format("EXEC CancelTicket @TicketID = {0}, @TicketCost = {1}, @PointCost = {2};", _ticketId, currencyCost, pointsCost);

        //Should alter one row by changing its IsRefunded attribute
        bool success = dao.Update(query) == 1;

        foreach(Flight flight in flights)
        {
            query = String.Format("EXEC UpdateFlightAfterCancel @FlightID = {0}, @CustomerID = {1};", flight.GetFlightId(), _customerId);

            //If its false once we return false
            success = success && dao.Update(query) > 0;
        }
        return success;
    }

}