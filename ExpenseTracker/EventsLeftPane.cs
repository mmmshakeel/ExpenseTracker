using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class EventsLeftPaneForm : Form
    {
        public EventsLeftPaneForm()
        {
            InitializeComponent();
        }

        public ShowEvents ShowEventsForm { get; set; }
        public AddEvent AddEventForm { get; set; }

        private void AppointmentsMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowEventsForm.UpdateFormHeading(sender);
            this.ShowEventsForm.Activate();
            this.ShowEventsForm.Show();
            this.ShowEventsForm.BringToFront();
        }

        private void TasksMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowEventsForm.UpdateFormHeading(sender);
            this.ShowEventsForm.Activate();
            this.ShowEventsForm.Show();
            this.ShowEventsForm.BringToFront();
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            this.AddEventForm.Activate();
            this.AddEventForm.Show();
            this.AddEventForm.BringToFront();
        }
    }
}
