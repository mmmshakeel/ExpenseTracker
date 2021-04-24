//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpenseTracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public System.DateTime Date { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }
        public string TransactionType { get; set; }
        public string RecurrentType { get; set; }
        public int ExpenseCategoryId { get; set; }
        public int IncomeSourceId { get; set; }
    
        public virtual ExpenseCategory ExpenseCategory { get; set; }
        public virtual IncomeSource IncomeSource { get; set; }
        public virtual Event Event { get; set; }
    }
}