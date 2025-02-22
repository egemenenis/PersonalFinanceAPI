﻿namespace PersonalFinanceAPI.Core.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
    }

    public enum TransactionType
    {
        Income,
        Expense
    }
}