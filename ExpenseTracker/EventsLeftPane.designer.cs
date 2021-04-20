
namespace ExpenseTracker
{
    partial class EventsLeftPaneForm
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
            this.tasksMenuLabel = new System.Windows.Forms.Label();
            this.appointmentsMenuLabel = new System.Windows.Forms.Label();
            this.buttonNewEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tasksMenuLabel
            // 
            this.tasksMenuLabel.AutoSize = true;
            this.tasksMenuLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tasksMenuLabel.Location = new System.Drawing.Point(37, 124);
            this.tasksMenuLabel.Name = "tasksMenuLabel";
            this.tasksMenuLabel.Size = new System.Drawing.Size(40, 17);
            this.tasksMenuLabel.TabIndex = 9;
            this.tasksMenuLabel.Text = "Tasks";
            this.tasksMenuLabel.Click += new System.EventHandler(this.TasksMenuItem_Click);
            // 
            // appointmentsMenuLabel
            // 
            this.appointmentsMenuLabel.AutoSize = true;
            this.appointmentsMenuLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.appointmentsMenuLabel.Location = new System.Drawing.Point(37, 92);
            this.appointmentsMenuLabel.Name = "appointmentsMenuLabel";
            this.appointmentsMenuLabel.Size = new System.Drawing.Size(95, 17);
            this.appointmentsMenuLabel.TabIndex = 8;
            this.appointmentsMenuLabel.Text = "Appointments";
            this.appointmentsMenuLabel.Click += new System.EventHandler(this.AppointmentsMenuItem_Click);
            // 
            // buttonNewEvent
            // 
            this.buttonNewEvent.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonNewEvent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNewEvent.Location = new System.Drawing.Point(31, 41);
            this.buttonNewEvent.Name = "buttonNewEvent";
            this.buttonNewEvent.Size = new System.Drawing.Size(130, 30);
            this.buttonNewEvent.TabIndex = 7;
            this.buttonNewEvent.Text = "New Event";
            this.buttonNewEvent.UseVisualStyleBackColor = false;
            this.buttonNewEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // EventsLeftPaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(232, 488);
            this.Controls.Add(this.tasksMenuLabel);
            this.Controls.Add(this.appointmentsMenuLabel);
            this.Controls.Add(this.buttonNewEvent);
            this.Name = "EventsLeftPaneForm";
            this.Text = "Events Pane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tasksMenuLabel;
        private System.Windows.Forms.Label appointmentsMenuLabel;
        private System.Windows.Forms.Button buttonNewEvent;
    }
}