
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
            this.panelAppointments = new System.Windows.Forms.Panel();
            this.dateTimePickerEvents = new System.Windows.Forms.DateTimePicker();
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
            // panelAppointments
            // 
            this.panelAppointments.AutoScroll = true;
            this.panelAppointments.Location = new System.Drawing.Point(5, 36);
            this.panelAppointments.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelAppointments.Name = "panelAppointments";
            this.panelAppointments.Size = new System.Drawing.Size(669, 351);
            this.panelAppointments.TabIndex = 1;
            // 
            // dateTimePickerEvents
            // 
            this.dateTimePickerEvents.CustomFormat = "MM-YYYY";
            this.dateTimePickerEvents.Location = new System.Drawing.Point(139, 10);
            this.dateTimePickerEvents.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePickerEvents.Name = "dateTimePickerEvents";
            this.dateTimePickerEvents.Size = new System.Drawing.Size(187, 20);
            this.dateTimePickerEvents.TabIndex = 2;
            // 
            // ShowEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 460);
            this.Controls.Add(this.labelEventType);
            this.Controls.Add(this.dateTimePickerEvents);
            this.Controls.Add(this.panelAppointments);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ShowEvents";
            this.Text = "Show Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventType;
        private System.Windows.Forms.Panel panelAppointments;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvents;
    }
}