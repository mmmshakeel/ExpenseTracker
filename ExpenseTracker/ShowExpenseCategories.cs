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
    public partial class ShowExpenseCategories : Form
    {
        //public const String ExpenseCategoriesFileName = "ExpenseCategories.xml";

        ExpenseTrackerDB expenseTrackerDataSet = new ExpenseTrackerDB();

        public ShowExpenseCategories()
        {
            InitializeComponent();

            if (File.Exists("ExpenseTrackerDB.ExpenseCategories.xml") == true)
            {
                this.expenseTrackerDataSet.ExpenseCategory.ReadXml("ExpenseTrackerDB.ExpenseCategories.xml");
            }

            this.textBoxExpenseCategory.Text = this.expenseTrackerDataSet.ExpenseCategory.Rows[0][1].ToString();
        }

        private void save(object sender, EventArgs e)
        {
            ExpenseTrackerDB.ExpenseCategoryRow categoryRow = this.expenseTrackerDataSet.ExpenseCategory.NewExpenseCategoryRow();
            categoryRow.Name = this.textBoxExpenseCategory.Text;

            this.expenseTrackerDataSet.ExpenseCategory.AddExpenseCategoryRow(categoryRow);
            this.expenseTrackerDataSet.AcceptChanges();

            // write to xml before forwarding to EF
            this.expenseTrackerDataSet.ExpenseCategory.WriteXml("ExpenseTrackerDB.ExpenseCategories.xml");

            // forward to DB  
            ExpenseCategoryModel expenseCategoryModel = new ExpenseCategoryModel();
            expenseCategoryModel.AddCategory(this.textBoxExpenseCategory.Text);

            // delete the xml file when sucess.
        }
    }
}
