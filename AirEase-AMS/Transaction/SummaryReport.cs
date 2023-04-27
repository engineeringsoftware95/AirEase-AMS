using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.Transaction;

public class SummaryReport
{
    private string report;
    private List<Flight> _listOfFlights;
    private List<AirEase_AMS.Transaction.Transaction> _transactions;



    public void GenerateReport()
    {
        report = "";
        foreach (Transaction t in _transactions)
        {
            report += t._transactionId + ",";
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



    public void GatherTransactions()
    {
        
    }

    public void PopulateFlightList()
    {
        
    }



}