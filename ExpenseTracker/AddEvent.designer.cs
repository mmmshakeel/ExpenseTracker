
namespace ExpenseTracker
{
    partial class AddEvent
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
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.textBoxEventLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeEventFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEventTo = new System.Windows.Forms.DateTimePicker();
            this.comboEventRepeat = new System.Windows.Forms.ComboBox();
            this.comboEventReminder = new System.Windows.Forms.ComboBox();
            this.comboEventCurrency = new System.Windows.Forms.ComboBox();
            this.textBoxEventCost = new System.Windows.Forms.TextBox();
            this.textBoxEventDetails = new System.Windows.Forms.TextBox();
            this.buttonDiscardEvent = new System.Windows.Forms.Button();
            this.buttonSaveEvent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEventType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Event";
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(59, 101);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(277, 23);
            this.textBoxEventName.TabIndex = 1;
            // 
            // textBoxEventLocation
            // 
            this.textBoxEventLocation.Location = new System.Drawing.Point(59, 162);
            this.textBoxEventLocation.Name = "textBoxEventLocation";
            this.textBoxEventLocation.Size = new System.Drawing.Size(277, 23);
            this.textBoxEventLocation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(244, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // dateTimeEventFrom
            // 
            this.dateTimeEventFrom.Location = new System.Drawing.Point(59, 222);
            this.dateTimeEventFrom.Name = "dateTimeEventFrom";
            this.dateTimeEventFrom.Size = new System.Drawing.Size(164, 23);
            this.dateTimeEventFrom.TabIndex = 5;
            // 
            // dateTimeEventTo
            // 
            this.dateTimeEventTo.Location = new System.Drawing.Point(244, 222);
            this.dateTimeEventTo.Name = "dateTimeEventTo";
            this.dateTimeEventTo.Size = new System.Drawing.Size(164, 23);
            this.dateTimeEventTo.TabIndex = 6;
            // 
            // comboEventRepeat
            // 
            this.comboEventRepeat.FormattingEnabled = true;
            this.comboEventRepeat.Items.AddRange(new object[] {
            "Does not repeat",
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.comboEventRepeat.Location = new System.Drawing.Point(59, 276);
            this.comboEventRepeat.Name = "comboEventRepeat";
            this.comboEventRepeat.Size = new System.Drawing.Size(164, 23);
            this.comboEventRepeat.TabIndex = 7;
            // 
            // comboEventReminder
            // 
            this.comboEventReminder.FormattingEnabled = true;
            this.comboEventReminder.Items.AddRange(new object[] {
            "No reminder",
            "1 minute before",
            "5 minutes before",
            "1 hour before",
            "1 day before"});
            this.comboEventReminder.Location = new System.Drawing.Point(244, 276);
            this.comboEventReminder.Name = "comboEventReminder";
            this.comboEventReminder.Size = new System.Drawing.Size(164, 23);
            this.comboEventReminder.TabIndex = 8;
            // 
            // comboEventCurrency
            // 
            this.comboEventCurrency.FormattingEnabled = true;
            this.comboEventCurrency.Items.AddRange(new object[] {
            "LKR",
            "USD"});
            this.comboEventCurrency.Location = new System.Drawing.Point(60, 336);
            this.comboEventCurrency.Name = "comboEventCurrency";
            this.comboEventCurrency.Size = new System.Drawing.Size(61, 23);
            this.comboEventCurrency.TabIndex = 9;
            // 
            // textBoxEventCost
            // 
            this.textBoxEventCost.Location = new System.Drawing.Point(137, 336);
            this.textBoxEventCost.Name = "textBoxEventCost";
            this.textBoxEventCost.Size = new System.Drawing.Size(187, 23);
            this.textBoxEventCost.TabIndex = 10;
            // 
            // textBoxEventDetails
            // 
            this.textBoxEventDetails.Location = new System.Drawing.Point(59, 381);
            this.textBoxEventDetails.Multiline = true;
            this.textBoxEventDetails.Name = "textBoxEventDetails";
            this.textBoxEventDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEventDetails.Size = new System.Drawing.Size(458, 76);
            this.textBoxEventDetails.TabIndex = 11;
            // 
            // buttonDiscardEvent
            // 
            this.buttonDiscardEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDiscardEvent.Location = new System.Drawing.Point(538, 471);
            this.buttonDiscardEvent.Name = "buttonDiscardEvent";
            this.buttonDiscardEvent.Size = new System.Drawing.Size(90, 35);
            this.buttonDiscardEvent.TabIndex = 12;
            this.buttonDiscardEvent.Text = "Discard";
            this.buttonDiscardEvent.UseVisualStyleBackColor = true;
            this.buttonDiscardEvent.Click += new System.EventHandler(this.discard);
            // 
            // buttonSaveEvent
            // 
            this.buttonSaveEvent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaveEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveEvent.Location = new System.Drawing.Point(659, 471);
            this.buttonSaveEvent.Name = "buttonSaveEvent";
            this.buttonSaveEvent.Size = new System.Drawing.Size(90, 35);
            this.buttonSaveEvent.TabIndex = 13;
            this.buttonSaveEvent.Text = "Save";
            this.buttonSaveEvent.UseVisualStyleBackColor = false;
            this.buttonSaveEvent.Click += new System.EventHandler(this.save);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Event Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(59, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Event Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(59, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Repeat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(244, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Reminder:";
            // 
            // comboEventType
            // 
            this.comboEventType.FormattingEnabled = true;
            this.comboEventType.Items.AddRange(new object[] {
            "Appointment",
            "Task"});
            this.comboEventType.Location = new System.Drawing.Point(353, 101);
            this.comboEventType.Name = "comboEventType";
            this.comboEventType.Size = new System.Drawing.Size(164, 23);
            this.comboEventType.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(353, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Event Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(60, 315);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Event Cost:";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 531);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboEventType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSaveEvent);
            this.Controls.Add(this.buttonDiscardEvent);
            this.Controls.Add(this.textBoxEventDetails);
            this.Controls.Add(this.textBoxEventCost);
            this.Controls.Add(this.comboEventCurrency);
            this.Controls.Add(this.comboEventReminder);
            this.Controls.Add(this.comboEventRepeat);
            this.Controls.Add(this.dateTimeEventTo);
            this.Controls.Add(this.dateTimeEventFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEventLocation);
            this.Controls.Add(this.textBoxEventName);
            this.Controls.Add(this.label1);
            this.Name = "AddEvent";
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.NewEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.TextBox textBoxEventLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeEventFrom;
        private System.Windows.Forms.DateTimePicker dateTimeEventTo;
        private System.Windows.Forms.ComboBox comboEventRepeat;
        private System.Windows.Forms.ComboBox comboEventReminder;
        private System.Windows.Forms.ComboBox comboEventCurrency;
        private System.Windows.Forms.TextBox textBoxEventCost;
        private System.Windows.Forms.TextBox textBoxEventDetails;
        private System.Windows.Forms.Button buttonDiscardEvent;
        private System.Windows.Forms.Button buttonSaveEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEventType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}