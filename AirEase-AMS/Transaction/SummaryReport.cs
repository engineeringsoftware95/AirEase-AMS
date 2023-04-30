using AirEase_AMS.App.Graph.Flight;
using System.Data;

namespace AirEase_AMS.Transaction;

public class SummaryReport
{
    private string report;
    private List<Flight> _listOfFlights;
    private List<AirEase_AMS.Transaction.Transaction> _transactions;


    public SummaryReport() 
    {
        PopulateFlightList(); 
        GatherTransactions();
        report = "";
    }

    public int GetNumberOfFlights() { return _listOfFlights.Count; }
    public int GetNumberOfTransactions() {  return _transactions.Count; }

    public void GenerateReport()
    {
        report = "";
        foreach (Transaction t in _transactions)
        {
            report += t.GetTransactionId() + ",";
            report += t._currencyCost + ",";
        }

        report += ":";
        foreach (Flight f in _listOfFlights)
        {
            report += f.GetFlightId() + "," + f.GetSeats();
        }
    }


    public double CalculateYearlyGrossIncome()
    {
        GatherTransactions();

        return 0;
    }



    /// <summary>
    /// Populates the transaction list with data from the database.
    /// </summary>
    /// <returns>The number of transactions read in.</returns>
    public int GatherTransactions()
    {
        _transactions = new List<Transaction>();
        string query = "SELECT * FROM TRANSACTIONS;";
        DatabaseAccessObject dao = new DatabaseAccessObject();
        DataTable dt = dao.Retrieve(query);
        foreach(DataRow row in dt.Rows)
        {
            _transactions.Add(new Transaction(row["TransactionID"].ToString() ?? "-1"));
        }

        return _transactions.Count();
    }

    /// <summary>
    /// Populates the flight list with data from the database.
    /// </summary>
    /// <returns>The number of flights read in.</returns>
    public int PopulateFlightList()
    {
        _listOfFlights = new List<Flight>();
        string query = "EXEC GetFlightsAndDepartures;";
        DatabaseAccessObject dao = new DatabaseAccessObject();
        DataTable dt = dao.Retrieve(query);
        foreach(DataRow row in dt.Rows)
        {
            _listOfFlights.Add(new Flight(row["FlightID"].ToString() ?? "-1", row["DepartureID"].ToString() ?? "-1"));
        }
        return _listOfFlights.Count();
    }

    public string GetReport()
    {
        return report;
    }

}