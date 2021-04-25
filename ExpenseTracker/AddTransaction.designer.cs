
namespace ExpenseTracker
{
    partial class AddTransaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeTransaction = new System.Windows.Forms.DateTimePicker();
            this.comboTransactionCurrency = new System.Windows.Forms.ComboBox();
            this.textTransactionAmount = new System.Windows.Forms.TextBox();
            this.comboTransactionType = new System.Windows.Forms.ComboBox();
            this.comboTransactionCategory = new System.Windows.Forms.ComboBox();
            this.comboTransactionRecurrentType = new System.Windows.Forms.ComboBox();
            this.discardTransactionButton = new System.Windows.Forms.Button();
            this.saveTransactionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textTransactionDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Transaction";
            // 
            // dateTimeTransaction
            // 
            this.dateTimeTransaction.Location = new System.Drawing.Point(51, 94);
            this.dateTimeTransaction.Name = "dateTimeTransaction";
            this.dateTimeTransaction.Size = new System.Drawing.Size(172, 20);
            this.dateTimeTransaction.TabIndex = 1;
            // 
            // comboTransactionCurrency
            // 
            this.comboTransactionCurrency.FormattingEnabled = true;
            this.comboTransactionCurrency.Items.AddRange(new object[] {
            "LKR",
            "USD"});
            this.comboTransactionCurrency.Location = new System.Drawing.Point(51, 210);
            this.comboTransactionCurrency.Name = "comboTransactionCurrency";
            this.comboTransactionCurrency.Size = new System.Drawing.Size(51, 21);
            this.comboTransactionCurrency.TabIndex = 2;
            // 
            // textTransactionAmount
            // 
            this.textTransactionAmount.Location = new System.Drawing.Point(115, 210);
            this.textTransactionAmount.Name = "textTransactionAmount";
            this.textTransactionAmount.Size = new System.Drawing.Size(151, 20);
            this.textTransactionAmount.TabIndex = 3;
            this.textTransactionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTransactionAmount.Leave += new System.EventHandler(this.AmountFormat);
            // 
            // comboTransactionType
            // 
            this.comboTransactionType.FormattingEnabled = true;
            this.comboTransactionType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.comboTransactionType.Location = new System.Drawing.Point(279, 210);
            this.comboTransactionType.Name = "comboTransactionType";
            this.comboTransactionType.Size = new System.Drawing.Size(104, 21);
            this.comboTransactionType.TabIndex = 4;
            this.comboTransactionType.SelectedIndexChanged += new System.EventHandler(this.UpdateCategoryList);
            // 
            // comboTransactionCategory
            // 
            this.comboTransactionCategory.FormattingEnabled = true;
            this.comboTransactionCategory.Location = new System.Drawing.Point(51, 269);
            this.comboTransactionCategory.Name = "comboTransactionCategory";
            this.comboTransactionCategory.Size = new System.Drawing.Size(215, 21);
            this.comboTransactionCategory.TabIndex = 5;
            // 
            // comboTransactionRecurrentType
            // 
            this.comboTransactionRecurrentType.FormattingEnabled = true;
            this.comboTransactionRecurrentType.Items.AddRange(new object[] {
            "One-off",
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.comboTransactionRecurrentType.Location = new System.Drawing.Point(51, 333);
            this.comboTransactionRecurrentType.Name = "comboTransactionRecurrentType";
            this.comboTransactionRecurrentType.Size = new System.Drawing.Size(215, 21);
            this.comboTransactionRecurrentType.TabIndex = 6;
            // 
            // discardTransactionButton
            // 
            this.discardTransactionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.discardTransactionButton.Location = new System.Drawing.Point(461, 408);
            this.discardTransactionButton.Name = "discardTransactionButton";
            this.discardTransactionButton.Size = new System.Drawing.Size(77, 30);
            this.discardTransactionButton.TabIndex = 7;
            this.discardTransactionButton.Text = "Discard";
            this.discardTransactionButton.UseVisualStyleBackColor = true;
            this.discardTransactionButton.Click += new System.EventHandler(this.discard);
            // 
            // saveTransactionButton
            // 
            this.saveTransactionButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveTransactionButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.saveTransactionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveTransactionButton.Location = new System.Drawing.Point(565, 408);
            this.saveTransactionButton.Name = "saveTransactionButton";
            this.saveTransactionButton.Size = new System.Drawing.Size(77, 30);
            this.saveTransactionButton.TabIndex = 8;
            this.saveTransactionButton.Text = "Save";
            this.saveTransactionButton.UseVisualStyleBackColor = false;
            this.saveTransactionButton.Click += new System.EventHandler(this.save);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Transaction Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(51, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Transaction Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(279, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Transaction Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(51, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Transaction Category/Source:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(51, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Transaction Recurrence Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Transaction Details:";
            // 
            // textTransactionDetails
            // 
            this.textTransactionDetails.Location = new System.Drawing.Point(51, 153);
            this.textTransactionDetails.Name = "textTransactionDetails";
            this.textTransactionDetails.Size = new System.Drawing.Size(332, 20);
            this.textTransactionDetails.TabIndex = 15;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 483);
            this.Controls.Add(this.textTransactionDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveTransactionButton);
            this.Controls.Add(this.discardTransactionButton);
            this.Controls.Add(this.comboTransactionRecurrentType);
            this.Controls.Add(this.comboTransactionCategory);
            this.Controls.Add(this.comboTransactionType);
            this.Controls.Add(this.textTransactionAmount);
            this.Controls.Add(this.comboTransactionCurrency);
            this.Controls.Add(this.dateTimeTransaction);
            this.Controls.Add(this.label1);
            this.Name = "AddTransaction";
            this.Text = "Add Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeTransaction;
        private System.Windows.Forms.ComboBox comboTransactionCurrency;
        private System.Windows.Forms.TextBox textTransactionAmount;
        private System.Windows.Forms.ComboBox comboTransactionType;
        private System.Windows.Forms.ComboBox comboTransactionCategory;
        private System.Windows.Forms.ComboBox comboTransactionRecurrentType;
        private System.Windows.Forms.Button discardTransactionButton;
        private System.Windows.Forms.Button saveTransactionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTransactionDetails;
    }
}