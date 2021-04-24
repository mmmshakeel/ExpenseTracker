using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    public partial class AddTransaction : Form
    {
        ExpenseTrackerDB expenseTrackerDataSet = new ExpenseTrackerDB();
        TransactionModel transactionModel = new TransactionModel();
        ExpenseCategoryModel expenseCategoryModel = new ExpenseCategoryModel();
        IncomeSourceModel incomeSourceModel = new IncomeSourceModel();

        public AddTransaction()
        {
            InitializeComponent();

            // recover any last entered, unsaved data

            // set initial values
            this.comboTransactionCurrency.SelectedIndex = 0;
            this.comboTransactionType.SelectedIndex = 1;
            this.comboTransactionRecurrentType.SelectedIndex = 0;

            this.PopulateCategorySource();
        }

        private void save(object sender, EventArgs e)
        {
            try
            {
                // validate user input
                //this.ValidateRequired();

                ExpenseTrackerDB.TransactionRow transactionRow = this.expenseTrackerDataSet.Transaction.NewTransactionRow();
                transactionRow.Date = this.dateTimeTransaction.Value;
                transactionRow.Detail = this.textTransactionDetails.Text;
                transactionRow.Currency = this.comboTransactionCurrency.SelectedItem.ToString();
                transactionRow.Amount = this.ConvertAmountToDouble(this.textTransactionAmount.Text);
                transactionRow.TransactionType = this.comboTransactionType.SelectedItem.ToString();
                
                if (this.comboTransactionType.SelectedItem.ToString().Equals("Expense"))
                {
                    ExpenseTrackerDB.ExpenseCategoryRow expenseCategoryRow =
                        this.expenseTrackerDataSet.ExpenseCategory.NewExpenseCategoryRow();
                    expenseCategoryRow.Name = this.comboTransactionCategory.SelectedItem.ToString();

                    transactionRow.ExpenseCategoryRow = expenseCategoryRow;

                    this.expenseTrackerDataSet.Transaction.AddTransactionRow(transactionRow);
                    this.expenseTrackerDataSet.ExpenseCategory.AddExpenseCategoryRow(expenseCategoryRow);
                    this.expenseTrackerDataSet.AcceptChanges();
                } else
                {
                    transactionRow.IncomeSourceRow.Name = this.comboTransactionCategory.SelectedItem.ToString();
                }

                transactionRow.RecurrentType = this.comboTransactionRecurrentType.SelectedItem.ToString();

                // write to xml before forwarding to DB
                this.expenseTrackerDataSet.WriteXml("ExpenseTrackerDB.Transaction.xml");


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void PopulateCategorySource(String transactionType = "Expense")
        {
            if (transactionType.Equals("Expense"))
            {
                List<ExpenseCategory> expenseCategories = this.expenseCategoryModel.GetAll();

                this.comboTransactionCategory.Items.Clear();
                for (int i=0; i < expenseCategories.Count; i++)
                {
                    this.comboTransactionCategory.Items.Add(expenseCategories[i].Name);
                }
            }

            if (transactionType.Equals("Income"))
            {
                List<IncomeSource> incomeSources = this.incomeSourceModel.GetAll();

                this.comboTransactionCategory.Items.Clear();
                for (int i = 0; i < incomeSources.Count; i++)
                {
                    this.comboTransactionCategory.Items.Add(incomeSources[i].Name);
                }
            }
        }

        private void discard(object sender, EventArgs e)
        {

        }

        private void AmountFormat(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(textTransactionAmount.Text, out value))
            {
                this.textTransactionAmount.Text = String.Format("{0:N2}", value);
            } else
            {
                this.textTransactionAmount.Text = String.Empty;
            }
        }

        private double ConvertAmountToDouble(String amount)
        {
            Double value;
            if (Double.TryParse(amount, out value))
            {
                return Double.Parse(amount);
            }
            else
            {
                return 0.00;
            }
        }

        private void ValidateRequired()
        {
            if (this.textTransactionAmount.Text.Equals(String.Empty))
            {
                throw new Exception("Transaction amount is required!");
            }

            if (this.dateTimeTransaction.Text.Equals(String.Empty))
            {
                throw new Exception("Transaction date is required!");
            }

            if (this.textTransactionDetails.Text.Equals(String.Empty))
            {
                throw new Exception("Transaction detail is required!");
            }

            if (this.comboTransactionCategory.SelectedItem == null)
            {
                throw new Exception("Transaction category/source is required!");
            }
        }

        private void UpdateCategoryList(object sender, EventArgs e)
        {
            String selectedItem = ((ComboBox)sender).SelectedItem.ToString();
            this.PopulateCategorySource(selectedItem);
        }
    }
}
