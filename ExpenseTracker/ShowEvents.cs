using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    public partial class ShowEvents : Form
    {
        EventModel eventModel = new EventModel();

        public ShowEvents()
        {
            InitializeComponent();

            this.dateTimePickerEvents.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerEvents.CustomFormat = "MMMM yyyy";

            // load the list view for the first week of current month
            DateTime date = DateTime.Now;
            DateTime week1Start = new DateTime(date.Year, date.Month, 1);
            DateTime week1End = week1Start.AddDays(7);

            this.ShowList(week1Start, week1End);
            this.buttonWeek1.Select();
        }

        public void UpdateFormHeading(object sender, EventArgs e)
        {
            this.labelEventType.Text = ((Label)sender).Text;

            this.buttonWeek1.Select();
            this.ShowFirstWeekList(sender, e);
        }

        private void ShowList(DateTime startDate, DateTime endDate, String eventType = "Appointments")
        {
            List<Event> eventsList = this.eventModel.GetList(startDate, endDate, eventType);

            // clear the panel
            this.panelEvents.Controls.Clear();

            if (eventsList.Count == 0)
            {
                Label label = new Label();
                label.Text = "No event found on the selected date range";
                label.Font = new Font("Segoe UI Semibold", 9, FontStyle.Bold);
                label.ForeColor = Color.Maroon;
                label.Location = new Point(223, 52);
                label.Size = new Size(232, 15);

                this.panelEvents.Controls.Add(label);
                return;
            }

            // we have data, render them as a list
            Label[] labelName = new Label[eventsList.Count];
            Label[] labelLocation = new Label[eventsList.Count];
            Label[] labelStartDate = new Label[eventsList.Count];
            Label[] labelEndDate = new Label[eventsList.Count];
            Label[] labelCost = new Label[eventsList.Count];
            Label[] labelRepeat = new Label[eventsList.Count];
            Label[] labelReminder = new Label[eventsList.Count];

            for (int i = 0; i < eventsList.Count; i++)
            {
                labelName[i] = new Label();
                labelName[i].Text = eventsList[i].Name;
                labelName[i].Location = new Point(7, 10 + i * 70);
                labelName[i].Size = new Size(96, 13);

                labelLocation[i] = new Label();
                labelLocation[i].Text = eventsList[i].Location;
                labelLocation[i].Location = new Point(160, 10 + i * 70);
                labelLocation[i].Size = new Size(96, 13);

                labelStartDate[i] = new Label();
                labelStartDate[i].Text = eventsList[i].From.ToString("dd/MM/yyyy hh:mm tt");
                labelStartDate[i].Location = new Point(314, 10 + i * 70);
                labelStartDate[i].Size = new Size(114, 13);

                labelEndDate[i] = new Label();
                labelEndDate[i].Text = eventsList[i].To?.ToString("dd/MM/yyyy hh:mm tt");
                labelEndDate[i].Location = new Point(460, 10 + i * 70);
                labelEndDate[i].Size = new Size(114, 13);

                labelCost[i] = new Label();
                labelCost[i].Text = 
                    $"{eventsList[i].Currency} {this.ConvertStringToCurrency(eventsList[i].Cost)}";
                labelCost[i].Location = new Point(630, 10 + i * 70);
                labelCost[i].Size = new Size(73, 13);

                labelRepeat[i] = new Label();
                labelRepeat[i].Text = $"Repeat: {eventsList[i].Repeat}";
                labelRepeat[i].Font = new Font(labelRepeat[i].Font, FontStyle.Italic); 
                labelRepeat[i].Location = new Point(7, 35 + i * 70);
                labelRepeat[i].Size = new Size(74, 13);

                labelReminder[i] = new Label();
                labelReminder[i].Text = $"Reminder: {eventsList[i].Reminder}";
                labelReminder[i].Font = new Font(labelRepeat[i].Font, FontStyle.Italic);
                labelReminder[i].Location = new Point(104, 35 + i * 70);
                labelReminder[i].Size = new Size(121, 13);

                this.panelEvents.Controls.Add(labelName[i]);
                this.panelEvents.Controls.Add(labelLocation[i]);
                this.panelEvents.Controls.Add(labelStartDate[i]);
                this.panelEvents.Controls.Add(labelEndDate[i]);
                this.panelEvents.Controls.Add(labelCost[i]);
                this.panelEvents.Controls.Add(labelRepeat[i]);
                this.panelEvents.Controls.Add(labelReminder[i]);
            }

        }

        private void ShowFirstWeekList(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePickerEvents.Value;
            DateTime startDate = new DateTime(date.Year, date.Month, 1);
            DateTime endDate = startDate.AddDays(7);

            this.ShowList(startDate, endDate, this.labelEventType.Text);
        }

        private void ShowSecondWeekList(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePickerEvents.Value;
            DateTime monthStart = new DateTime(date.Year, date.Month, 1);
            DateTime startDate = monthStart.AddDays(8);
            DateTime endDate = startDate.AddDays(7);

            this.ShowList(startDate, endDate, this.labelEventType.Text);
        }

        private void ShowThirdWeekList(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePickerEvents.Value;
            DateTime monthStart = new DateTime(date.Year, date.Month, 1);
            DateTime startDate = monthStart.AddDays(15);
            DateTime endDate = startDate.AddDays(7);

            this.ShowList(startDate, endDate, this.labelEventType.Text);
        }

        private void ShowFourthWeekList(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePickerEvents.Value;
            DateTime monthStart = new DateTime(date.Year, date.Month, 1);
            DateTime startDate = monthStart.AddDays(22);
            DateTime endDate = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

            this.ShowList(startDate, endDate, this.labelEventType.Text);
        }

        private String ConvertStringToCurrency(double amount)
        {
            return String.Format("{0:N2}", amount);
        }

        private double ConvertAmountToDouble(String amount)
        {
            Double value;
            if (Double.TryParse(amount, out value))
            {
                return Double.Parse(amount);
            }
            else
            {
                return 0.00;
            }
        }

        private void panelEvents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
