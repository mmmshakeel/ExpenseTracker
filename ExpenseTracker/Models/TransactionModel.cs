using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    class TransactionModel
    {
        private ExpenseTrackerDatabaseContainer db = new ExpenseTrackerDatabaseContainer();

        public bool AddTransactionRecord(TransactionDetails transactionDetails)
        {
            Transaction transaction = new Transaction();

            transaction.Date = transactionDetails.date;
            transaction.Detail = transactionDetails.details;
            transaction.Currency = transactionDetails.currency;
            transaction.Amount = transactionDetails.amount;
            transaction.TransactionType = transactionDetails.type;
            transaction.RecurrentType = transactionDetails.recurrence;

            if (transactionDetails.type.Equals("Expense"))
            {
                ExpenseCategory expenseCategory = 
                    this.db.ExpenseCategories.Where(s => s.Name == transactionDetails.category).First();
                transaction.ExpenseCategoryId = expenseCategory.Id;
            } else
            {
                IncomeSource incomeSource =
                    this.db.IncomeSources.Where(s => s.Name == transactionDetails.category).First();
                transaction.IncomeSourceId = incomeSource.Id;
            }

            this.db.Transactions.Add(transaction);
            this.db.SaveChanges();
            return true;
        }

        public List<Transaction> GetList(DateTime startDate, DateTime endDate, ShowTransactionsList.TransactionType transactionType)
        {
            String transactionFilter = "";

            if (transactionType == ShowTransactionsList.TransactionType.Income)
            {
                transactionFilter = "Income";
            } else if (transactionType == ShowTransactionsList.TransactionType.Expense)
            {
                transactionFilter = "Expense";
            }

            if (transactionFilter.Equals(""))
            {
                using (var ctx = new ExpenseTrackerDatabaseContainer())
                {
                    return ctx.Transactions.Where(t => t.Date >= startDate)
                        .Where(t => t.Date <= endDate).ToList();
                }
            } else
            {
                using (var ctx = new ExpenseTrackerDatabaseContainer())
                {
                    return ctx.Transactions.Where(t => t.Date >= startDate)
                        .Where(t => t.Date <= endDate)
                        .Where(t => t.TransactionType == transactionFilter).ToList();
                }
            }
            
        }
    }
}
