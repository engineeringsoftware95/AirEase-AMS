﻿using AirEase_AMS.App;
using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Ticket;

namespace AirEase_AMS.Transaction;

public class Transaction
{
    private int _transactionId;
    private Ticket _ticket;
    private Customer _customer;

    public Transaction(int transactionId, Ticket ticket, Customer customer)
    {
        _transactionId = transactionId;
        _ticket = ticket;
        _customer = customer;
    }


    public void GenerateTransactionId()
    {
        _transactionId = HLib.GenerateFiveDigitId();
    }
}