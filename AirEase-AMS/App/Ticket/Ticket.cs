﻿using AirEase_AMS.App.Defs;
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

    private List<Flight> flights;

    public Ticket(int straightLineMileage, decimal ticketCost, string startCity, string endCity)
    {
        _straightLineMileage = straightLineMileage;
        _ticketCost = ticketCost;
        _ticketId = GenerateTicketId().ToString();
        _startCity = startCity;
        _endCity = endCity;
        _isRefunded = false;
        flights = new List<Flight>();
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

    public void AddFlight(Flight flight)
    {
        flights.Add(flight);
    }

    public int GenerateTicketId()
    {
       return HLib.GenerateSixDigitId();
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
    /// Attempts to insert this ticket into the database.
    /// </summary>
    /// <returns>Whether or not the ticket was successfully inserted.</returns>
    public bool PurchaseTicket()
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
    public bool CancelTicket()
    {
        DatabaseAccessObject dao = new DatabaseAccessObject();
        string query = "UPDATE TICKETS SET IsRefunded = 1 WHERE TicketID = " + _ticketId + ";";

        //Should alter one row by changing its IsRefunded attribute
        return dao.Update(query) == 1;
    }

}