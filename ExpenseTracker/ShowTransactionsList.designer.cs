
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControlTransactionList = new System.Windows.Forms.TabControl();
            this.transactionsDetailsListView = new System.Windows.Forms.TabPage();
            this.transactionsGraphView = new System.Windows.Forms.TabPage();
            this.tabControlTransactionList.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTransactionListHeading
            // 
            this.labelTransactionListHeading.AutoSize = true;
            this.labelTransactionListHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTransactionListHeading.Location = new System.Drawing.Point(59, 26);
            this.labelTransactionListHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTransactionListHeading.Name = "labelTransactionListHeading";
            this.labelTransactionListHeading.Size = new System.Drawing.Size(105, 21);
            this.labelTransactionListHeading.TabIndex = 0;
            this.labelTransactionListHeading.Text = "Transactions";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 29);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(373, 29);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(155, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Weekly";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "Monthly";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabControlTransactionList
            // 
            this.tabControlTransactionList.Controls.Add(this.transactionsDetailsListView);
            this.tabControlTransactionList.Controls.Add(this.transactionsGraphView);
            this.tabControlTransactionList.Location = new System.Drawing.Point(2, 65);
            this.tabControlTransactionList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControlTransactionList.Name = "tabControlTransactionList";
            this.tabControlTransactionList.SelectedIndex = 0;
            this.tabControlTransactionList.Size = new System.Drawing.Size(786, 450);
            this.tabControlTransactionList.TabIndex = 7;
            this.tabControlTransactionList.SelectedIndexChanged += new System.EventHandler(this.tabControlTransactionList_SelectedIndexChanged);
            // 
            // transactionsDetailsListView
            // 
            this.transactionsDetailsListView.AutoScroll = true;
            this.transactionsDetailsListView.Location = new System.Drawing.Point(4, 24);
            this.transactionsDetailsListView.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.transactionsDetailsListView.Name = "transactionsDetailsListView";
            this.transactionsDetailsListView.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.transactionsDetailsListView.Size = new System.Drawing.Size(778, 422);
            this.transactionsDetailsListView.TabIndex = 0;
            this.transactionsDetailsListView.Text = "Details List";
            this.transactionsDetailsListView.UseVisualStyleBackColor = true;
            // 
            // transactionsGraphView
            // 
            this.transactionsGraphView.Location = new System.Drawing.Point(4, 24);
            this.transactionsGraphView.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.transactionsGraphView.Name = "transactionsGraphView";
            this.transactionsGraphView.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.transactionsGraphView.Size = new System.Drawing.Size(778, 422);
            this.transactionsGraphView.TabIndex = 1;
            this.transactionsGraphView.Text = "Graph View";
            this.transactionsGraphView.UseVisualStyleBackColor = true;
            // 
            // ShowTransactionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 531);
            this.Controls.Add(this.tabControlTransactionList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelTransactionListHeading);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ShowTransactionsList";
            this.Text = "Show Transactions List";
            this.tabControlTransactionList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTransactionListHeading;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControlTransactionList;
        private System.Windows.Forms.TabPage transactionsDetailsListView;
        private System.Windows.Forms.TabPage transactionsGraphView;
    }
}