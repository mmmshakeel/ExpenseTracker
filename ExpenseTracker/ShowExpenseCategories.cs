using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExpenseTracker.Models;
using ExpenseTracker.CustomElements;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public partial class ShowExpenseCategories : Form
    {
       
        ExpenseTrackerDB expenseTrackerDataSet = new ExpenseTrackerDB();
        ExpenseCategoryModel expenseCategoryModel = new ExpenseCategoryModel();
        CategoryButton updateButton;

        public ShowExpenseCategories()
        {
            InitializeComponent();

            // recover any last entered, unsaved data
            if (File.Exists("ExpenseTrackerDB.ExpenseCategories.xml") == true &&
                this.expenseTrackerDataSet.ExpenseCategory.Rows.Count > 0)
            {
                this.expenseTrackerDataSet.ExpenseCategory.ReadXml("ExpenseTrackerDB.ExpenseCategories.xml");
                this.textBoxExpenseCategory.Text = this.expenseTrackerDataSet.ExpenseCategory.Rows[0][1].ToString();
            }


            this.panelExpenseCategories.HorizontalScroll.Enabled = false;
            this.panelExpenseCategories.HorizontalScroll.Visible = false;

            // initialize list
            this.ShowExpenseList();

            // create a custom button for upate category
            this.updateButton = new CustomElements.CategoryButton();
            this.updateButton.Size = new System.Drawing.Size(70, 32);
            this.updateButton.Location = new System.Drawing.Point(355, 433);
            this.updateButton.Text = "Update";
            this.updateButton.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
            this.updateButton.BackColor = SystemColors.ActiveCaption;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateExpenseCategory);
            this.Controls.Add(updateButton);
        }

        private async void save(object sender, EventArgs e)
        {
            // check for empty value
            if (this.textBoxExpenseCategory.Text.Equals(""))
            {
                return;
            }

            ExpenseTrackerDB.ExpenseCategoryRow categoryRow = this.expenseTrackerDataSet.ExpenseCategory.NewExpenseCategoryRow();
            categoryRow.Name = this.textBoxExpenseCategory.Text;

            this.expenseTrackerDataSet.ExpenseCategory.AddExpenseCategoryRow(categoryRow);
            this.expenseTrackerDataSet.AcceptChanges();

            // write to xml before forwarding to DB
            this.expenseTrackerDataSet.ExpenseCategory.WriteXml("ExpenseTrackerDB.ExpenseCategories.xml");

            // forward to DB  
            try
            {
                bool result = await this.expenseCategoryModel.AddCategory(this.textBoxExpenseCategory.Text);
                if (result == true)
                {
                    // delete the xml file when sucess.
                    this.deleteFile("ExpenseTrackerDB.ExpenseCategories.xml");
                    this.textBoxExpenseCategory.Text = "";

                    // refresh list
                    this.ShowExpenseList();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private List<ExpenseCategory> GetList()
        {
            return this.expenseCategoryModel.GetAll();
        }

        private void ShowExpenseList()
        {
            List<ExpenseCategory> expenseCategories = this.GetList();

            // clear the panel always
            this.panelExpenseCategories.Controls.Clear();

            // create arrays for dynamic view
            ExpenseCategoryRow[] expenseCategoryRows = new ExpenseCategoryRow[expenseCategories.Count];

            for (int i = 0; i < expenseCategories.Count; i++)
            {
                expenseCategoryRows[i] = new ExpenseCategoryRow();
                expenseCategoryRows[i].SetExpenseCategoryLabel(expenseCategories[i].Name);
                expenseCategoryRows[i].SetButtonId(expenseCategories[i].Id);

                expenseCategoryRows[i].SetDeleteEventHandler(this.DeleteExpenseCategory);
                expenseCategoryRows[i].SetEditEventHandler(this.Edit);

                if (i % 2 > 0)
                {
                    expenseCategoryRows[i].SetBackColor();
                }

                expenseCategoryRows[i].Location = new System.Drawing.Point(1, 3 + i * 30);
                expenseCategoryRows[i].Size = new System.Drawing.Size(600, 30);

                this.panelExpenseCategories.Controls.Add(expenseCategoryRows[i]);

            }
        }

        private async void DeleteExpenseCategory(object sender, EventArgs e)
        {
            // ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure to delete the category?",
                "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int catId = ((CategoryButton)sender).Id;
                await this.expenseCategoryModel.DeleteCategory(catId);

                // refresh list
                this.ShowExpenseList();
            }

        }

        private void Edit(object sender, EventArgs e)
        {
            this.buttonExpenseCategorySave.Visible = false;
            this.updateButton.Visible = true;

            int catId = ((CategoryButton)sender).Id;
            ExpenseCategory category = this .expenseCategoryModel.GetExpenseCategory(catId);

            if (category != null)
            {
                this.textBoxExpenseCategory.Text = category.Name;
                this.updateButton.Id = category.Id;
            }
        }

        private async void UpdateExpenseCategory(object sender, EventArgs e)
        {
            int catId = ((CustomElements.CategoryButton)sender).Id;

            // check for empty value
            if (this.textBoxExpenseCategory.Text.Equals(""))
            {
                return;
            }

            ExpenseTrackerDB.ExpenseCategoryRow categoryRow = this.expenseTrackerDataSet.ExpenseCategory.NewExpenseCategoryRow();
            categoryRow.Name = this.textBoxExpenseCategory.Text;

            this.expenseTrackerDataSet.ExpenseCategory.AddExpenseCategoryRow(categoryRow);
            this.expenseTrackerDataSet.AcceptChanges();

            // write to xml before forwarding to DB
            await this.WriteFileAsync(this.expenseTrackerDataSet);

            // forward to DB  
            try
            {
                ExpenseCategoryModel expenseCategoryModel = new ExpenseCategoryModel();

                bool result = await this.expenseCategoryModel.UpdateCategory(this.textBoxExpenseCategory.Text, catId);
                if (result == true)
                {
                    // delete the xml file when sucess.
                    this.deleteFile("ExpenseTrackerDB.ExpenseCategories.xml");
                    this.textBoxExpenseCategory.Text = "";

                    // refresh list
                    this.ShowExpenseList();
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
            this.textBoxExpenseCategory.Text = String.Empty;
            this.updateButton.Id = 0;
            this.updateButton.Visible = false;
            this.buttonExpenseCategorySave.Visible = true;
        }

        private async Task<Boolean> WriteFileAsync(ExpenseTrackerDB expenseTrackerDataSet)
        {
            await Task.Run(() => {
                this.expenseTrackerDataSet.ExpenseCategory.WriteXml("ExpenseTrackerDB.ExpenseCategories.xml");
            });

            return true;
        }
    }
}
