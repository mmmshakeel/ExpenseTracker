using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class FinanceLeftPaneForm : Form
    {

        public FinanceLeftPaneForm()
        {
            InitializeComponent();

        }

        public ShowTransactionsList TransactionsListForm { get; set; }
        public ShowIncomeSources IncomeSourcesForm { get; set; }
        public ShowExpenseCategories ExpenseCategoriesForm { get; set; }
        public AddTransaction AddTransactionForm { get; set; }

        private void FinanceLeftPaneForm_Load(object sender, EventArgs e)
        {

        }

        private void TransactionsMenuItem_Click(object sender, EventArgs e)
        {
            this.TransactionsListForm.UpdateFormHeading(ShowTransactionsList.TransactionType.All);
            this.TransactionsListForm.Show();
            this.TransactionsListForm.BringToFront();
        }

        private void IncomeMenuItem_Click(object sender, EventArgs e)
        {
            this.TransactionsListForm.UpdateFormHeading(ShowTransactionsList.TransactionType.Income);
            this.TransactionsListForm.Show();
            this.TransactionsListForm.BringToFront();
        }

        private void ExpenseMenuItem_Click(object sender, EventArgs e)
        {
            this.TransactionsListForm.UpdateFormHeading(ShowTransactionsList.TransactionType.Expense);
            this.TransactionsListForm.Show();
            this.TransactionsListForm.BringToFront();
        }

        private void IncomeSourcesMenuItem_Click(object sender, EventArgs e)
        {
            this.IncomeSourcesForm.Show();
            this.IncomeSourcesForm.BringToFront();
        }

        private void ExpenseCategoriesMenuItem_Click(object sender, EventArgs e)
        {
            this.ExpenseCategoriesForm.Show();
            this.ExpenseCategoriesForm.BringToFront();
        }

        private void NewTransaction_Click(object sender, EventArgs e)
        {
            this.AddTransactionForm.Activate();
            this.AddTransactionForm.Show();
            this.AddTransactionForm.BringToFront();
        }
    }
}
