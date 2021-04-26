
namespace ExpenseTracker
{
    partial class ShowTransactionsList
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
            this.labelTransactionListHeading = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonWeek = new System.Windows.Forms.Button();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.transactionsDetailsListView = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlTransactionList = new System.Windows.Forms.TabControl();
            this.labelTotalTransactionAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.transactionsDetailsListView.SuspendLayout();
            this.tabControlTransactionList.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTransactionListHeading
            // 
            this.labelTransactionListHeading.AutoSize = true;
            this.labelTransactionListHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTransactionListHeading.Location = new System.Drawing.Point(51, 23);
            this.labelTransactionListHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTransactionListHeading.Name = "labelTransactionListHeading";
            this.labelTransactionListHeading.Size = new System.Drawing.Size(105, 21);
            this.labelTransactionListHeading.TabIndex = 0;
            this.labelTransactionListHeading.Text = "Transactions";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(167, 30);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(133, 20);
            this.dateTimeStart.TabIndex = 1;
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.LoadCustomRangeList);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "To:";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(320, 30);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(133, 20);
            this.dateTimeEnd.TabIndex = 4;
            this.dateTimeEnd.ValueChanged += new System.EventHandler(this.LoadCustomRangeList);
            // 
            // buttonWeek
            // 
            this.buttonWeek.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeek.Location = new System.Drawing.Point(476, 24);
            this.buttonWeek.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Size = new System.Drawing.Size(70, 32);
            this.buttonWeek.TabIndex = 5;
            this.buttonWeek.Text = "Weekly";
            this.buttonWeek.UseVisualStyleBackColor = true;
            this.buttonWeek.Click += new System.EventHandler(this.ShowLast7DaysList);
            // 
            // buttonMonth
            // 
            this.buttonMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonth.Location = new System.Drawing.Point(561, 24);
            this.buttonMonth.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(70, 32);
            this.buttonMonth.TabIndex = 6;
            this.buttonMonth.Text = "Monthly";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.Click += new System.EventHandler(this.ShowLast30DaysList);
            // 
            // transactionsDetailsListView
            // 
            this.transactionsDetailsListView.AutoScroll = true;
            this.transactionsDetailsListView.Controls.Add(this.label13);
            this.transactionsDetailsListView.Controls.Add(this.label12);
            this.transactionsDetailsListView.Controls.Add(this.label11);
            this.transactionsDetailsListView.Controls.Add(this.label10);
            this.transactionsDetailsListView.Controls.Add(this.label9);
            this.transactionsDetailsListView.Controls.Add(this.label8);
            this.transactionsDetailsListView.Controls.Add(this.label7);
            this.transactionsDetailsListView.Controls.Add(this.label6);
            this.transactionsDetailsListView.Controls.Add(this.label5);
            this.transactionsDetailsListView.Controls.Add(this.label4);
            this.transactionsDetailsListView.Location = new System.Drawing.Point(4, 24);
            this.transactionsDetailsListView.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.transactionsDetailsListView.Name = "transactionsDetailsListView";
            this.transactionsDetailsListView.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.transactionsDetailsListView.Size = new System.Drawing.Size(666, 362);
            this.transactionsDetailsListView.TabIndex = 0;
            this.transactionsDetailsListView.Text = "Details List";
            this.transactionsDetailsListView.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Transaction Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Transaction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // tabControlTransactionList
            // 
            this.tabControlTransactionList.Controls.Add(this.transactionsDetailsListView);
            this.tabControlTransactionList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlTransactionList.Location = new System.Drawing.Point(2, 56);
            this.tabControlTransactionList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControlTransactionList.Name = "tabControlTransactionList";
            this.tabControlTransactionList.SelectedIndex = 0;
            this.tabControlTransactionList.Size = new System.Drawing.Size(674, 390);
            this.tabControlTransactionList.TabIndex = 7;
            this.tabControlTransactionList.SelectedIndexChanged += new System.EventHandler(this.tabControlTransactionList_SelectedIndexChanged);
            // 
            // labelTotalTransactionAmount
            // 
            this.labelTotalTransactionAmount.AutoSize = true;
            this.labelTotalTransactionAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTransactionAmount.Location = new System.Drawing.Point(539, 455);
            this.labelTotalTransactionAmount.Name = "labelTotalTransactionAmount";
            this.labelTotalTransactionAmount.Size = new System.Drawing.Size(130, 17);
            this.labelTotalTransactionAmount.TabIndex = 0;
            this.labelTotalTransactionAmount.Text = "Total: LKR 120,000.00";
            this.labelTotalTransactionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "26/04/2021";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Gym membership payment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Expense";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(575, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "LKR 2350.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(299, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Category/Source";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Gym and Fitness";
            // 
            // ShowTransactionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 485);
            this.Controls.Add(this.labelTotalTransactionAmount);
            this.Controls.Add(this.tabControlTransactionList);
            this.Controls.Add(this.buttonMonth);
            this.Controls.Add(this.buttonWeek);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.labelTransactionListHeading);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ShowTransactionsList";
            this.Text = "Show Transactions List";
            this.transactionsDetailsListView.ResumeLayout(false);
            this.transactionsDetailsListView.PerformLayout();
            this.tabControlTransactionList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTransactionListHeading;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Button buttonWeek;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.TabPage transactionsDetailsListView;
        private System.Windows.Forms.TabControl tabControlTransactionList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalTransactionAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}