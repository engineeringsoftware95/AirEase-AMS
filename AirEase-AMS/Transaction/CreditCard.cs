namespace AirEase_AMS.App.Ticket;

public class CreditCard
{
    private string? _ccNum;
    private string? _expDate;
    private string? _cvc;
    private string? _accountHolderName;

    public CreditCard(string? ccNum)
    {
        _ccNum = ccNum;
    }


    public void SaveCreditCard(string num, string date, string cvc, string accountHolder)
    {
        
    }
    

}