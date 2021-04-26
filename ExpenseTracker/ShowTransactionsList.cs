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
    public partial class ShowTransactionsList : Form
    {
        TransactionModel transactionModel = new TransactionModel();
        ExpenseCategoryModel expenseCategoryModel = new ExpenseCategoryModel();
        IncomeSourceModel incomeSourceModel = new IncomeSourceModel();

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
            this.currentTransactionType = TransactionType.All;

            // load last 7 days transaction as default
            this.LoadDefaultList();
        }

        public void UpdateFormHeading(TransactionType transactionType)
        {
            if (transactionType == TransactionType.All)
            {
                this.labelTransactionListHeading.Text = "Transactions";
                this.currentTransactionType = TransactionType.All;
            }

            if (transactionType == TransactionType.Income)
            {
                this.labelTransactionListHeading.Text = "Incomes";
                this.currentTransactionType = TransactionType.Income;
            }

            if (transactionType == TransactionType.Expense)
            {
                this.labelTransactionListHeading.Text = "Expenses";
                this.currentTransactionType = TransactionType.Expense;
            }

            this.LoadDefaultList();
        }


        private void GetList(DateTime startDate, DateTime endDate, TransactionType transactionType)
        {
            List<Transaction> transactionList = this.transactionModel.GetList(startDate, endDate, transactionType);

            // clear the panel
            this.transactionsDetailsListView.Controls.Clear();

            // create the list headings
            Label headingDate = new Label
            {
                Text = "Date",
                Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold),
                Location = new Point(20, 5),
                Size = new Size(34, 15)
            };
            Label headingName = new Label
            {
                Text = "Transaction",
                Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold),
                Location = new Point(116, 5),
                Size = new Size(70, 15)
            };
            Label headingCategory = new Label
            {
                Text = "Category/Source",
                Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold),
                Location = new Point(299, 5),
                Size = new Size(101, 15)
            };
            Label headingType = new Label
            {
                Text = "Transaction Type",
                Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold),
                Location = new Point(445, 5),
                Size = new Size(99, 15)
            };
            Label headingRecurrence = new Label
            {
                Text = "Recurrence",
                Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold),
                Location = new Point(578, 5),
                Size = new Size(99, 15)
            };
            Label headingAmount = new Label
            {
                Text = "Amount",
                Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold),
                Location = new Point(680, 5),
                Size = new Size(52, 15)
            };

            this.transactionsDetailsListView.Controls.Add(headingDate);
            this.transactionsDetailsListView.Controls.Add(headingName);
            this.transactionsDetailsListView.Controls.Add(headingCategory);
            this.transactionsDetailsListView.Controls.Add(headingType);
            this.transactionsDetailsListView.Controls.Add(headingRecurrence);
            this.transactionsDetailsListView.Controls.Add(headingAmount);

            if (transactionList.Count == 0)
            {
                Label label = new Label();
                label.Text = "No transactions found on the selected date range";
                label.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
                label.ForeColor = Color.Maroon;
                label.Location = new Point(223, 52);
                label.Size = new Size(232, 15);

                this.transactionsDetailsListView.Controls.Add(label);
                return;
            }

            Label[] labelDate = new Label[transactionList.Count];
            Label[] labelName = new Label[transactionList.Count];
            Label[] labelCategory = new Label[transactionList.Count];
            Label[] labelType = new Label[transactionList.Count];
            Label[] labelRecurrence = new Label[transactionList.Count];
            Label[] labelAmount = new Label[transactionList.Count];

            double totalTransactionAmount = 0.00;
            for (int i = 0; i < transactionList.Count; i++)
            {
                labelDate[i] = new Label
                {
                    Text = transactionList[i].Date.ToString("dd/MM/yyyy"),
                    Location = new Point(5, 29 + i * 25),
                    Size = new Size(65, 15)
                };
                labelName[i] = new Label { 
                    Text = transactionList[i].Detail,
                    Location = new Point(116, 29 + i * 25),
                    Size = new Size(115, 15)
                };

                if (transactionList[i].TransactionType.Equals("Expense"))
                {
                    ExpenseCategory expenseCategory = 
                        this.expenseCategoryModel.GetExpenseCategory(transactionList[i].ExpenseCategoryId);
                    labelCategory[i] = new Label
                    {
                        Text = expenseCategory.Name,
                        Location = new Point(299, 29 + i * 25),
                        Size = new Size(94, 15)
                    };
                } else
                {
                    IncomeSource incomeSource =
                        this.incomeSourceModel.GetIncomeSource(transactionList[i].IncomeSourceId);
                    labelCategory[i] = new Label
                    {
                        Text = incomeSource.Name,
                        Location = new Point(299, 29 + i * 25),
                        Size = new Size(94, 15)
                    };
                }

                labelType[i] = new Label
                {
                    Text = transactionList[i].TransactionType,
                    Location = new Point(445, 29 + i * 25),
                    Size = new Size(50, 15)
                };
                labelRecurrence[i] = new Label
                {
                    Text = transactionList[i].RecurrentType,
                    Location = new Point(578, 29 + i * 25),
                    Size = new Size(99, 15)
                };
                labelAmount[i] = new Label
                {
                    Text = $"{transactionList[i].Currency} {this.ConvertStringToCurrency(transactionList[i].Amount)}",
                    Location = new Point(660, 29 + i * 25),
                    Size = new Size(100, 15),
                    TextAlign = ContentAlignment.MiddleRight
                };

                totalTransactionAmount += transactionList[i].Amount;
                this.transactionsDetailsListView.Controls.Add(labelDate[i]);
                this.transactionsDetailsListView.Controls.Add(labelName[i]);
                this.transactionsDetailsListView.Controls.Add(labelCategory[i]);
                this.transactionsDetailsListView.Controls.Add(labelType[i]);
                this.transactionsDetailsListView.Controls.Add(labelRecurrence[i]);
                this.transactionsDetailsListView.Controls.Add(labelAmount[i]);
            }

            this.labelTotalTransactionAmount.Text = $"Total: LKR {this.ConvertStringToCurrency(totalTransactionAmount)}";
        }

        private String ConvertStringToCurrency(double amount)
        {
            return String.Format("{0:N2}", amount);
        }

        private void tabControlTransactionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadDefaultList()
        {
            this.buttonWeek.Select();
            DateTime today = DateTime.Today;
            DateTime last7Day = today.AddDays(-7);
            this.dateTimeStart.Value = last7Day;
            this.dateTimeEnd.Value = today;
            this.GetList(last7Day, today, this.currentTransactionType);
        }

        private void ShowLast7DaysList(object sender, EventArgs e)
        {
            this.LoadDefaultList();
        }

        private void ShowLast30DaysList(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime last30Day = today.AddDays(-30);
            this.dateTimeStart.Value = last30Day;
            this.dateTimeEnd.Value = today;

            this.GetList(last30Day, today, this.currentTransactionType);
        }

        private void LoadCustomRangeList(object sender, EventArgs e)
        {
            this.GetList(this.dateTimeStart.Value, this.dateTimeEnd.Value, this.currentTransactionType);
        }
    }
}
