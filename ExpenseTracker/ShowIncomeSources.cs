using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExpenseTracker.Models;
using ExpenseTracker.CustomElements;
using System.IO;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public partial class ShowIncomeSources : Form
    {
        ExpenseTrackerDB expenseTrackerDataSet = new ExpenseTrackerDB();
        IncomeSourceModel incomeSourceModel = new IncomeSourceModel();
        CategoryButton updateButton;

        public ShowIncomeSources()
        {
            InitializeComponent();

            // recover any last entered, unsaved data
            if (File.Exists("ExpenseTrackerDB.IncomeSources.xml") == true &&
                this.expenseTrackerDataSet.IncomeSource.Rows.Count > 0)
            {
                this.expenseTrackerDataSet.IncomeSource.ReadXml("ExpenseTrackerDB.IncomeSources.xml");
                this.textBoxIncomeSource.Text = this.expenseTrackerDataSet.IncomeSource.Rows[0][1].ToString();
            }

            this.panelIncomeSource.HorizontalScroll.Enabled = false;
            this.panelIncomeSource.HorizontalScroll.Visible = false;

            // initialize list
            this.ShowIncomeSourceList();

            // create a custom button for upate category
            this.updateButton = new CustomElements.CategoryButton();
            this.updateButton.Size = new System.Drawing.Size(70, 32);
            this.updateButton.Location = new System.Drawing.Point(340, 430);
            this.updateButton.Text = "Update";
            this.updateButton.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            this.updateButton.BackColor = SystemColors.ActiveCaption;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateIncomeSource);
            this.Controls.Add(updateButton);
        }

        private async void Save(object sender, EventArgs e)
        {
            // check for empty value
            if (this.textBoxIncomeSource.Text.Equals(""))
            {
                return;
            }
           
            // forward to DB  
            try
            {

                ExpenseTrackerDB.IncomeSourceRow incomeSourceRow = this.expenseTrackerDataSet.IncomeSource.NewIncomeSourceRow();
                incomeSourceRow.Name = this.textBoxIncomeSource.Text;

                this.expenseTrackerDataSet.IncomeSource.AddIncomeSourceRow(incomeSourceRow);
                this.expenseTrackerDataSet.AcceptChanges();

                // write to xml before forwarding to DB
                this.expenseTrackerDataSet.ExpenseCategory.WriteXml("ExpenseTrackerDB.IncomeSources.xml");

                bool saveResult = await this.incomeSourceModel.AddIncomeSourceAsync(this.textBoxIncomeSource.Text);
                if (saveResult == true)
                {
                    // delete the xml file when sucess.
                    this.deleteFile("ExpenseTrackerDB.IncomeSources.xml");
                    this.textBoxIncomeSource.Text = "";

                    // refresh list
                    this.ShowIncomeSourceList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<IncomeSource> GetList()
        {
            return this.incomeSourceModel.GetAll();
        }

        private void ShowIncomeSourceList()
        {
            List<IncomeSource> incomeSources = this.GetList();

            // clear the panel always
            this.panelIncomeSource.Controls.Clear();

            // create arrays for dynamic view, use same expenseCategoryRows for income sources as well
            ExpenseCategoryRow[] expenseCategoryRows = new ExpenseCategoryRow[incomeSources.Count];

            for (int i = 0; i < incomeSources.Count; i++)
            {
                expenseCategoryRows[i] = new ExpenseCategoryRow();
                expenseCategoryRows[i].SetExpenseCategoryLabel(incomeSources[i].Name);
                expenseCategoryRows[i].SetButtonId(incomeSources[i].Id);

                expenseCategoryRows[i].SetDeleteEventHandler(this.DeleteExpenseCategory);
                expenseCategoryRows[i].SetEditEventHandler(this.Edit);

                if (i % 2 > 0)
                {
                    expenseCategoryRows[i].SetBackColor();
                }

                expenseCategoryRows[i].Location = new System.Drawing.Point(1, 3 + i * 30);
                expenseCategoryRows[i].Size = new System.Drawing.Size(600, 30);

                this.panelIncomeSource.Controls.Add(expenseCategoryRows[i]);

            }
        }

        private async void DeleteExpenseCategory(object sender, EventArgs e)
        {
            // ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure to delete the income source?",
                "Delete Income Source", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int catId = ((CategoryButton)sender).Id;
                await this.incomeSourceModel.DeleteIncomeSourceAsync(catId);

                // refresh list
                this.ShowIncomeSourceList();
            }

        }

        private void Edit(object sender, EventArgs e)
        {
            this.buttonIncomeSourceSave.Visible = false;
            this.updateButton.Visible = true;

            int catId = ((CategoryButton)sender).Id;
            IncomeSource incomeSource = this.incomeSourceModel.GetIncomeSource(catId);

            if (incomeSource != null)
            {
                this.textBoxIncomeSource.Text = incomeSource.Name;
                this.updateButton.Id = incomeSource.Id;
            }
        }

        private async void UpdateIncomeSource(object sender, EventArgs e)
        {
            int catId = ((CustomElements.CategoryButton)sender).Id;

            // check for empty value
            if (this.textBoxIncomeSource.Text.Equals(""))
            {
                return;
            }

            ExpenseTrackerDB.IncomeSourceRow incomeSourceRow = this.expenseTrackerDataSet.IncomeSource.NewIncomeSourceRow();
            incomeSourceRow.Name = this.textBoxIncomeSource.Text;

            this.expenseTrackerDataSet.IncomeSource.AddIncomeSourceRow(incomeSourceRow);
            this.expenseTrackerDataSet.AcceptChanges();

            // write to xml before forwarding to DB
            await this.WriteFileAsync(this.expenseTrackerDataSet);

            // forward to DB  
            try
            {
                bool result = await this.incomeSourceModel.UpdateIncomeSourceAsync(this.textBoxIncomeSource.Text, catId);
                if (result == true)
                {
                    // delete the xml file when sucess.
                    this.deleteFile("ExpenseTrackerDB.IncomeSources.xml");
                    this.textBoxIncomeSource.Text = "";

                    // refresh list
                    this.ShowIncomeSourceList();
                    this.Discard(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteFile(String filepath)
        {
            if (File.Exists(filepath) == true)
            {
                File.Delete(filepath);
            }
        }

        private void Discard(object sender, EventArgs e)
        {
            this.textBoxIncomeSource.Text = String.Empty;
            this.updateButton.Id = 0;
            this.updateButton.Visible = false;
            this.buttonIncomeSourceSave.Visible = true;
        }

        private async Task<Boolean> WriteFileAsync(ExpenseTrackerDB expenseTrackerDataSet)
        {
            await Task.Run(() => {
                this.expenseTrackerDataSet.ExpenseCategory.WriteXml("ExpenseTrackerDB.IncomeSources.xml");
            });
            return true;
        }
    }
}
