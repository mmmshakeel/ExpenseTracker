
namespace ExpenseTracker
{
    partial class FinanceLeftPaneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newTransactionButton = new System.Windows.Forms.Button();
            this.transactionsMenuLabel = new System.Windows.Forms.Label();
            this.incomeMenuLabel = new System.Windows.Forms.Label();
            this.expenseMenuLabel = new System.Windows.Forms.Label();
            this.incomeSourcesMenuLabel = new System.Windows.Forms.Label();
            this.expenseCategoriesMenuLabel = new System.Windows.Forms.Label();
            this.financePredictorMenuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newTransactionButton
            // 
            this.newTransactionButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.newTransactionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newTransactionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newTransactionButton.Location = new System.Drawing.Point(37, 46);
            this.newTransactionButton.Name = "newTransactionButton";
            this.newTransactionButton.Size = new System.Drawing.Size(149, 34);
            this.newTransactionButton.TabIndex = 0;
            this.newTransactionButton.Text = "New Transaction";
            this.newTransactionButton.UseVisualStyleBackColor = false;
            // 
            // transactionsMenuLabel
            // 
            this.transactionsMenuLabel.AutoSize = true;
            this.transactionsMenuLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transactionsMenuLabel.Location = new System.Drawing.Point(43, 104);
            this.transactionsMenuLabel.Name = "transactionsMenuLabel";
            this.transactionsMenuLabel.Size = new System.Drawing.Size(83, 17);
            this.transactionsMenuLabel.TabIndex = 1;
            this.transactionsMenuLabel.Text = "Transactions";
            this.transactionsMenuLabel.Click += new System.EventHandler(this.TransactionsMenuItem_Click);
            // 
            // incomeMenuLabel
            // 
            this.incomeMenuLabel.AutoSize = true;
            this.incomeMenuLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.incomeMenuLabel.Location = new System.Drawing.Point(43, 141);
            this.incomeMenuLabel.Name = "incomeMenuLabel";
            this.incomeMenuLabel.Size = new System.Drawing.Size(53, 17);
            this.incomeMenuLabel.TabIndex = 2;
            this.incomeMenuLabel.Text = "Income";
            this.incomeMenuLabel.Click += new System.EventHandler(this.IncomeMenuItem_Click);
            // 
            // expenseMenuLabel
            // 
            this.expenseMenuLabel.AutoSize = true;
            this.expenseMenuLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expenseMenuLabel.Location = new System.Drawing.Point(43, 177);
            this.expenseMenuLabel.Name = "expenseMenuLabel";
            this.expenseMenuLabel.Size = new System.Drawing.Size(58, 17);
            this.expenseMenuLabel.TabIndex = 3;
            this.expenseMenuLabel.Text = "Expense";
            this.expenseMenuLabel.Click += new System.EventHandler(this.ExpenseMenuItem_Click);
            // 
            // incomeSourcesMenuLabel
            // 
            this.incomeSourcesMenuLabel.AutoSize = true;
            this.incomeSourcesMenuLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.incomeSourcesMenuLabel.Location = new System.Drawing.Point(43, 213);
            this.incomeSourcesMenuLabel.Name = "incomeSourcesMenuLabel";
            this.incomeSourcesMenuLabel.Size = new System.Drawing.Size(104, 17);
            this.incomeSourcesMenuLabel.TabIndex = 4;
            this.incomeSourcesMenuLabel.Text = "Income Sources";
            this.incomeSourcesMenuLabel.Click += new System.EventHandler(this.IncomeSourcesMenuItem_Click);
            // 
            // expenseCategoriesMenuLabel
            // 
            this.expenseCategoriesMenuLabel.AutoSize = true;
            this.expenseCategoriesMenuLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expenseCategoriesMenuLabel.Location = new System.Drawing.Point(43, 249);
            this.expenseCategoriesMenuLabel.Name = "expenseCategoriesMenuLabel";
            this.expenseCategoriesMenuLabel.Size = new System.Drawing.Size(126, 17);
            this.expenseCategoriesMenuLabel.TabIndex = 5;
            this.expenseCategoriesMenuLabel.Text = "Expense Categories";
            this.expenseCategoriesMenuLabel.Click += new System.EventHandler(this.ExpenseCategoriesMenuItem_Click);
            // 
            // financePredictorMenuLabel
            // 
            this.financePredictorMenuLabel.AutoSize = true;
            this.financePredictorMenuLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.financePredictorMenuLabel.Location = new System.Drawing.Point(43, 286);
            this.financePredictorMenuLabel.Name = "financePredictorMenuLabel";
            this.financePredictorMenuLabel.Size = new System.Drawing.Size(113, 17);
            this.financePredictorMenuLabel.TabIndex = 6;
            this.financePredictorMenuLabel.Text = "Finance Predictor";
            // 
            // FinanceLeftPaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(232, 488);
            this.Controls.Add(this.financePredictorMenuLabel);
            this.Controls.Add(this.expenseCategoriesMenuLabel);
            this.Controls.Add(this.incomeSourcesMenuLabel);
            this.Controls.Add(this.expenseMenuLabel);
            this.Controls.Add(this.incomeMenuLabel);
            this.Controls.Add(this.transactionsMenuLabel);
            this.Controls.Add(this.newTransactionButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FinanceLeftPaneForm";
            this.Text = "Finance Pane";
            this.Load += new System.EventHandler(this.FinanceLeftPaneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newTransactionButton;
        private System.Windows.Forms.Label transactionsMenuLabel;
        private System.Windows.Forms.Label incomeMenuLabel;
        private System.Windows.Forms.Label expenseMenuLabel;
        private System.Windows.Forms.Label incomeSourcesMenuLabel;
        private System.Windows.Forms.Label expenseCategoriesMenuLabel;
        private System.Windows.Forms.Label financePredictorMenuLabel;
    }
}