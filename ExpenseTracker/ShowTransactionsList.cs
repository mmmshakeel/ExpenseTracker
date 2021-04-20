using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class ShowTransactionsList : Form
    {
        public enum TransactionType
        {
            All,
            Income,
            Expense
        }

        public TransactionType SelectedTransactionType { get; set; }
        private TransactionType currentTransactionType = TransactionType.All;

        public ShowTransactionsList()
        {
            InitializeComponent();

            // default heading for the form
            this.labelTransactionListHeading.Text = "Transactions";
        }

        public void UpdateFormHeading(TransactionType transactionType)
        {
            if (transactionType == TransactionType.All)
            {
                this.labelTransactionListHeading.Text = "Transactions";
            }

            if (transactionType == TransactionType.Income)
            {
                this.labelTransactionListHeading.Text = "Incomes";
            }

            if (transactionType == TransactionType.Expense)
            {
                this.labelTransactionListHeading.Text = "Expenses";
            }
        }

        private void tabControlTransactionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
