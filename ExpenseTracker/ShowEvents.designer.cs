
namespace ExpenseTracker
{
    partial class ShowEvents
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
            this.labelEventType = new System.Windows.Forms.Label();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.dateTimePickerEvents = new System.Windows.Forms.DateTimePicker();
            this.buttonWeek1 = new System.Windows.Forms.Button();
            this.buttonWeek2 = new System.Windows.Forms.Button();
            this.buttonWeek3 = new System.Windows.Forms.Button();
            this.buttonWeek4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEventType
            // 
            this.labelEventType.AutoSize = true;
            this.labelEventType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelEventType.Location = new System.Drawing.Point(5, 10);
            this.labelEventType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEventType.Name = "labelEventType";
            this.labelEventType.Size = new System.Drawing.Size(130, 21);
            this.labelEventType.TabIndex = 0;
            this.labelEventType.Text = "LabelEventType";
            // 
            // panelEvents
            // 
            this.panelEvents.AutoScroll = true;
            this.panelEvents.Controls.Add(this.label12);
            this.panelEvents.Controls.Add(this.label6);
            this.panelEvents.Controls.Add(this.label5);
            this.panelEvents.Controls.Add(this.label11);
            this.panelEvents.Controls.Add(this.label10);
            this.panelEvents.Controls.Add(this.label9);
            this.panelEvents.Controls.Add(this.label8);
            this.panelEvents.Location = new System.Drawing.Point(5, 84);
            this.panelEvents.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(669, 366);
            this.panelEvents.TabIndex = 1;
            this.panelEvents.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEvents_Paint);
            // 
            // dateTimePickerEvents
            // 
            this.dateTimePickerEvents.CustomFormat = "MMMM yyyy";
            this.dateTimePickerEvents.Location = new System.Drawing.Point(139, 10);
            this.dateTimePickerEvents.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePickerEvents.Name = "dateTimePickerEvents";
            this.dateTimePickerEvents.Size = new System.Drawing.Size(155, 20);
            this.dateTimePickerEvents.TabIndex = 2;
            // 
            // buttonWeek1
            // 
            this.buttonWeek1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonWeek1.Location = new System.Drawing.Point(326, 8);
            this.buttonWeek1.Name = "buttonWeek1";
            this.buttonWeek1.Size = new System.Drawing.Size(75, 23);
            this.buttonWeek1.TabIndex = 3;
            this.buttonWeek1.Text = "Week 1";
            this.buttonWeek1.UseVisualStyleBackColor = true;
            this.buttonWeek1.Click += new System.EventHandler(this.ShowFirstWeekList);
            // 
            // buttonWeek2
            // 
            this.buttonWeek2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeek2.Location = new System.Drawing.Point(412, 8);
            this.buttonWeek2.Name = "buttonWeek2";
            this.buttonWeek2.Size = new System.Drawing.Size(75, 23);
            this.buttonWeek2.TabIndex = 4;
            this.buttonWeek2.Text = "Week 2";
            this.buttonWeek2.UseVisualStyleBackColor = true;
            this.buttonWeek2.Click += new System.EventHandler(this.ShowSecondWeekList);
            // 
            // buttonWeek3
            // 
            this.buttonWeek3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonWeek3.Location = new System.Drawing.Point(498, 8);
            this.buttonWeek3.Name = "buttonWeek3";
            this.buttonWeek3.Size = new System.Drawing.Size(75, 23);
            this.buttonWeek3.TabIndex = 5;
            this.buttonWeek3.Text = "Week 3";
            this.buttonWeek3.UseVisualStyleBackColor = true;
            this.buttonWeek3.Click += new System.EventHandler(this.ShowThirdWeekList);
            // 
            // buttonWeek4
            // 
            this.buttonWeek4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonWeek4.Location = new System.Drawing.Point(584, 8);
            this.buttonWeek4.Name = "buttonWeek4";
            this.buttonWeek4.Size = new System.Drawing.Size(75, 23);
            this.buttonWeek4.TabIndex = 6;
            this.buttonWeek4.Text = "Week 4";
            this.buttonWeek4.UseVisualStyleBackColor = true;
            this.buttonWeek4.Click += new System.EventHandler(this.ShowFourthWeekList);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(545, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Event Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Event Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "This is a test event";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "This is a test event";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "25/04/2021 08:10 PM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(398, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "25/04/2021 08:10 PM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "LKR 2,500.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Repeat: None";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(104, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Reminder: 1 hour before";
            // 
            // ShowEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWeek4);
            this.Controls.Add(this.buttonWeek3);
            this.Controls.Add(this.buttonWeek2);
            this.Controls.Add(this.buttonWeek1);
            this.Controls.Add(this.labelEventType);
            this.Controls.Add(this.dateTimePickerEvents);
            this.Controls.Add(this.panelEvents);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ShowEvents";
            this.Text = "Show Events";
            this.panelEvents.ResumeLayout(false);
            this.panelEvents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventType;
        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvents;
        private System.Windows.Forms.Button buttonWeek1;
        private System.Windows.Forms.Button buttonWeek2;
        private System.Windows.Forms.Button buttonWeek3;
        private System.Windows.Forms.Button buttonWeek4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}