using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            // set initial values
            this.comboTransactionCurrency.SelectedIndex = 0;
            this.comboTransactionType.SelectedIndex = 1;
            this.comboTransactionRecurrentType.SelectedIndex = 0;

            this.PopulateCategorySource();

            // recover any last entered, unsaved data
            if (File.Exists("ExpenseTrackerDB.Transaction.xml") == true )
            {
                this.expenseTrackerDataSet.ReadXml("ExpenseTrackerDB.Transaction.xml");

                this.textTransactionDetails.Text = this.expenseTrackerDataSet.Transaction.Rows[0][1].ToString();
                this.dateTimeTransaction.Value = this.ConvertStringToDate(
                    this.expenseTrackerDataSet.Transaction.Rows[0][2].ToString());
                this.textTransactionAmount.Text = this.ConvertStringToCurrency(
                    this.expenseTrackerDataSet.Transaction.Rows[0][4].ToString());
                this.comboTransactionCategory.SelectedIndex = (int)this.expenseTrackerDataSet.ExpenseCategory.Rows[0][0];
            }

           
        }

        private void save(object sender, EventArgs e)
        {
            try
            {
                TransactionDetails transactionDetails = new TransactionDetails();

                // validate user input
                this.ValidateRequired();

                ExpenseTrackerDB.TransactionRow transactionRow = this.expenseTrackerDataSet.Transaction.NewTransactionRow();
                transactionRow.Date = this.dateTimeTransaction.Value;
                transactionRow.Detail = this.textTransactionDetails.Text;
                transactionRow.Currency = this.comboTransactionCurrency.SelectedItem.ToString();
                transactionRow.Amount = this.ConvertAmountToDouble(this.textTransactionAmount.Text);
                transactionRow.TransactionType = this.comboTransactionType.SelectedItem.ToString();
                transactionRow.RecurrentType = this.comboTransactionRecurrentType.SelectedItem.ToString();

                if (this.comboTransactionType.SelectedItem.ToString().Equals("Expense"))
                {
                    ExpenseTrackerDB.ExpenseCategoryRow expenseCategoryRow =
                        this.expenseTrackerDataSet.ExpenseCategory.NewExpenseCategoryRow();
                    expenseCategoryRow.Name = this.comboTransactionCategory.SelectedItem.ToString();

                    transactionRow.ExpenseCategoryRow = expenseCategoryRow;
                    this.expenseTrackerDataSet.Transaction.AddTransactionRow(transactionRow);
                    this.expenseTrackerDataSet.ExpenseCategory.AddExpenseCategoryRow(expenseCategoryRow);
                    
                } else
                {
                    ExpenseTrackerDB.IncomeSourceRow incomeSourceRow =
                        this.expenseTrackerDataSet.IncomeSource.NewIncomeSourceRow();
                    incomeSourceRow.Name = this.comboTransactionCategory.SelectedItem.ToString();

                    transactionRow.IncomeSourceRow = incomeSourceRow;
                    this.expenseTrackerDataSet.Transaction.AddTransactionRow(transactionRow);
                    this.expenseTrackerDataSet.IncomeSource.AddIncomeSourceRow(incomeSourceRow);
                }

                this.expenseTrackerDataSet.AcceptChanges();

                // write to xml before forwarding to DB
                this.expenseTrackerDataSet.WriteXml("ExpenseTrackerDB.Transaction.xml");

                // write to db
                transactionDetails.date = this.dateTimeTransaction.Value;
                transactionDetails.details = this.textTransactionDetails.Text;
                transactionDetails.currency = this.comboTransactionCurrency.SelectedItem.ToString();
                transactionDetails.amount = this.ConvertAmountToDouble(this.textTransactionAmount.Text);
                transactionDetails.type = this.comboTransactionType.SelectedItem.ToString();
                transactionDetails.category = this.comboTransactionCategory.SelectedItem.ToString();
                transactionDetails.recurrence = this.comboTransactionRecurrentType.SelectedItem.ToString();

                if (this.transactionModel.AddTransactionRecord(transactionDetails) == true)
                {
                    // delete the xml file when sucess.
                    this.deleteFile("ExpenseTrackerDB.Transaction.xml");

                    // show success message
                    MessageBox.Show("Transaction saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // clean up form
                    this.discard(sender, e);
                }


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
            this.textTransactionAmount.Text = String.Empty;
            this.textTransactionDetails.Text = String.Empty;
            this.comboTransactionCategory.SelectedIndex = 0;
            this.comboTransactionRecurrentType.SelectedIndex = 0;
        }

        private void deleteFile(String filepath)
        {
            if (File.Exists(filepath) == true)
            {
                File.Delete(filepath);
            }
        }

        private void AmountFormat(object sender, EventArgs e)
        {
            this.textTransactionAmount.Text = this.ConvertStringToCurrency(this.textTransactionAmount.Text);
        }

        private String ConvertStringToCurrency(String amount)
        {
            Double value;
            if (Double.TryParse(amount, out value))
            {
                return String.Format("{0:N2}", value);
            }

            return String.Empty;
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

        private DateTime ConvertStringToDate(String date)
        {
            DateTime value;
            if (DateTime.TryParse(date, out value))
            {
                return DateTime.Parse(date);
            }

            return DateTime.Now;

            //https://stackoverflow.com/questions/919244/converting-a-string-to-datetime
        }
    }
}
