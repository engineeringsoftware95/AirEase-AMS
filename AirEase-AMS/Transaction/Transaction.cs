using AirEase_AMS.App;
using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Ticket;

namespace AirEase_AMS.Transaction;

public class Transaction
{
    private string _transactionId;
    public decimal _currencyCost { get; }
    public int _pointCost { get; }
    public string _customerId { get; }

    /// <summary>
    /// Transaction constructor designed for creating a NEW transaction. 
    /// </summary>
    /// <param name="currencyCost">The cost in USD.</param>
    /// <param name="pointCost">The points cost based on our currency-to-points metric.</param>
    /// <param name="customerId">The customer ID associated with this transaction.</param>
    public Transaction(decimal currencyCost, int pointsCost, string customerId)
    {
        //This class is currently in an invalid state
        if(currencyCost != 0 && pointsCost != 0)
        {
            _transactionId = "-1";
            _currencyCost = -1;
            _pointCost = -1;
            _customerId = "-1";
        }
        else
        {
            _transactionId = GenerateTransactionId();
            _currencyCost = currencyCost;
            _pointCost = pointsCost;
            _customerId = customerId;
        }
    }

    /// <summary>
    /// Transaction constructor designed for instantiating a previously existing transaction.
    /// </summary>
    /// <param name="transactionId">The transaction ID of the transaction being searched for.</param>
    public Transaction(string transactionId)
    {
        _transactionId = transactionId;
        string query = String.Format("EXEC SelectTransaction @TransactionID = {0};", transactionId);
        DatabaseAccessObject dao = new DatabaseAccessObject();
        System.Data.DataTable dt = dao.Retrieve(query);

        //Invalid read
        if (dt == null || dt.Rows.Count != 1)
        {
            //Abort by setting all member data to some null value. This read failed.
            _transactionId = "-1";
            _currencyCost = 0;
            _pointCost = 0;
            _customerId = "-1";
        }
        else
        {
            System.Data.DataRow transaction = dt.Rows[0];

            //Return -1 on invalid read
            _currencyCost = decimal.Parse(transaction["CurrencyCost"].ToString() ?? "-1");
            _pointCost = int.Parse(transaction["PointCost"].ToString() ?? "-1");
            _customerId = transaction["UserID"].ToString() ?? "-1";
        }
    }

    public string GetTransactionId() { return _transactionId; }

    /// <summary>
    /// This function attempts to upload this transaction object to the database. The transaction must be created before the ticket.
    /// </summary>
    /// <returns>Whether or not the function succeeded.</returns>
    public bool UploadTransaction()
    {
        DatabaseAccessObject dao = new DatabaseAccessObject();

        //While the ID isn't unique, make a new one.
        _transactionId = (GenerateTransactionId());
        while (dao.Retrieve("SELECT * FROM TRANSACTIONS WHERE TransactionID=" + _transactionId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _transactionId = (GenerateTransactionId());
        }

        string query = String.Format("EXEC InsertTransaction @TransactionID = {0}, @TicketCost = {1}, @PointCost = {2}, @CustomerID = {3};", _transactionId, _currencyCost, _pointCost, _customerId);
        return (dao.Update(query) >= 1);
    }

    public string GenerateTransactionId()
    {
        return HLib.GenerateSixDigitId().ToString();
    }
}