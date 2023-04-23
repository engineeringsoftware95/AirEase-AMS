using System.Data;

namespace AirEase_AMS.App.Ticket;

public class CreditCard
{
    private string _ccNum;
    private string _expDate;
    private string _cvc;
    private string _accountHolderId;
    private string _billingZipCode;

    /// <summary>
    /// Credit card constructor which sets the class members with info from the database.
    /// </summary>
    /// <param name="ccNum">The credit card number selected on.</param>
    public CreditCard(string ccNum)
    {
        _ccNum = ccNum;
        string query = String.Format("EXEC RetrieveCreditCard @CreditCardNum = '{0}';", _ccNum);
        DatabaseAccessObject dao = new DatabaseAccessObject();

        System.Data.DataTable dt = dao.Retrieve(query);

        //Invalid read
        if (dt == null || dt.Rows.Count != 1)
        {
            _ccNum = "";
            _expDate = "";
            _cvc = "";
            _accountHolderId = "";
            _billingZipCode = "";
        }
        else
        {
            DataRow card = dt.Rows[0];

            //Return empty string on invalid read
            _ccNum = card["CreditCardNum"].ToString() ?? "";
            _expDate = card["ExpirationDate"].ToString() ?? "";
            _cvc = card["CVC"].ToString() ?? "";
            _billingZipCode = card["ZipCode"].ToString() ?? "";
            _accountHolderId = card["UserId"].ToString() ?? "";
        }
    }

    /// <summary>
    /// This constructor is designed to create a new credit card object.
    /// </summary>
    /// <param name="ccNum">New credit card number.</param>
    /// <param name="expDate">Credit card expiration date.</param>
    /// <param name="cvc">Credit card cvc.</param>
    /// <param name="billingZipCode">Billing zip code of card owner.</param>
    /// <param name="accountHolderId">User id of the user who owns the card.</param>
    public CreditCard(string ccNum, string expDate, string cvc, string billingZipCode, string accountHolderId) 
    {
        //Valid credit cards are 13 characters in length at LEAST
        //All characters must be NUMERIC
        if (ccNum.Length < 13 || ccNum.Any(ch => ! char.IsNumber(ch))) _ccNum = "";
        else _ccNum= ccNum;
        _expDate = expDate;
        _cvc= cvc;
        _accountHolderId = accountHolderId;
        _billingZipCode = billingZipCode;
    }

    /// <summary>
    /// Attempts to upload this credit card object to the database.
    /// </summary>
    /// <returns>Returns whether or not the function succeeded.</returns>
    public bool SaveCreditCard()
    {
        DatabaseAccessObject dao = new DatabaseAccessObject();

        string query = String.Format("EXEC SaveCreditCard @CreditCardNum = '{0}', @ExpirationDate = '{1}', @CVC = {2}, @ZipCode = '{3}', @CustomerID = {4};", _ccNum, _expDate, _cvc, _billingZipCode, _accountHolderId);

        //If rows returned is equal to one, it means we updated one row in the database.
        return (dao.Update(query) == 1);
    }

    public string GetCustomerId()
    {
        return _accountHolderId;
    }
}