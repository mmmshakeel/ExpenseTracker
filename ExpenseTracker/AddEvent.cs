using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    public partial class AddEvent : Form
    {
        ExpenseTrackerDB expenseTrackerDataSet = new ExpenseTrackerDB();
        EventModel eventModel = new EventModel();

        public AddEvent()
        {
            InitializeComponent();

            // set initial values
            this.comboEventType.SelectedIndex = 0;
            this.comboEventRepeat.SelectedIndex = 0;
            this.comboEventReminder.SelectedIndex = 0;
            this.comboEventCurrency.SelectedIndex = 0;

            this.dateTimeEventFrom.Format = DateTimePickerFormat.Custom;
            this.dateTimeEventFrom.CustomFormat = "dd/MM/yyyy hh:mm tt";

            this.dateTimeEventTo.Format = DateTimePickerFormat.Custom;
            this.dateTimeEventTo.CustomFormat = "dd/MM/yyyy hh:mm tt";

            if (File.Exists("ExpenseTrackerDB.Event.xml") == true)
            {
                // get the last row
                this.expenseTrackerDataSet.Event.ReadXml("ExpenseTrackerDB.Event.xml");

                int lastRow = this.expenseTrackerDataSet.Event.Rows.Count - 1;
                this.textBoxEventName.Text = this.expenseTrackerDataSet.Event.Rows[lastRow][1].ToString();
                this.textBoxEventLocation.Text = this.expenseTrackerDataSet.Event.Rows[lastRow][3].ToString();
                this.dateTimeEventFrom.Value = this.ConvertStringToDate(
                    this.expenseTrackerDataSet.Event.Rows[lastRow][4].ToString());
                this.dateTimeEventTo.Value = this.ConvertStringToDate(
                    this.expenseTrackerDataSet.Event.Rows[lastRow][5].ToString());
                this.textBoxEventCost.Text = this.ConvertStringToCurrency(
                    this.expenseTrackerDataSet.Event.Rows[lastRow][9].ToString());
                this.textBoxEventDetails.Text = this.expenseTrackerDataSet.Event.Rows[lastRow][10].ToString();
            }
        }

        private void save(object sender, EventArgs e)
        {
            try
            {
                EventDetails eventDetails = new EventDetails();
                this.ValidateRequiredFields();

                // temp store before push to database
                ExpenseTrackerDB.EventRow eventRow = this.expenseTrackerDataSet.Event.NewEventRow();
                eventRow.Name = this.textBoxEventName.Text;
                eventRow.Location = this.textBoxEventLocation.Text;
                eventRow.EventType = this.comboEventType.SelectedItem.ToString();
                eventRow.From = this.dateTimeEventFrom.Value;
                eventRow.To = this.dateTimeEventTo.Value;
                eventRow.Repeat = this.comboEventRepeat.SelectedItem.ToString();
                eventRow.Reminder = this.comboEventReminder.SelectedItem.ToString();
                eventRow.Currency = this.comboEventCurrency.SelectedItem.ToString();
                eventRow.Cost = this.ConvertAmountToDouble(this.textBoxEventCost.Text);
                eventRow.Details = this.textBoxEventDetails.Text;

                this.expenseTrackerDataSet.Event.AddEventRow(eventRow);
                this.expenseTrackerDataSet.AcceptChanges();

                // wrtie to xml
                this.expenseTrackerDataSet.Event.WriteXml("ExpenseTrackerDB.Event.xml");

                // save to database
                eventDetails.Name = this.textBoxEventName.Text;
                eventDetails.Location = this.textBoxEventLocation.Text;
                eventDetails.EventType = this.comboEventType.SelectedItem.ToString();
                eventDetails.From = this.dateTimeEventFrom.Value;
                eventDetails.To = this.dateTimeEventTo.Value;
                eventDetails.Repeat = this.comboEventRepeat.SelectedItem.ToString();
                eventDetails.Reminder = this.comboEventReminder.SelectedItem.ToString();
                eventDetails.Currency = this.comboEventCurrency.SelectedItem.ToString();
                eventDetails.Cost = this.ConvertAmountToDouble(this.textBoxEventCost.Text);
                eventDetails.Details = this.textBoxEventDetails.Text;

                if (this.eventModel.AddEvent(eventDetails) == true)
                {
                    // delete the xml file when sucess.
                    this.deleteFile("ExpenseTrackerDB.Event.xml");

                    // show success message
                    MessageBox.Show("Event saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // clean up form
                    this.discard(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ValidateRequiredFields()
        {
            if (this.textBoxEventName.Text.Equals(String.Empty))
            {
                throw new Exception("Event name is required!");
            }

            if (this.dateTimeEventFrom.Value.ToString().Equals(String.Empty))
            {
                throw new Exception("Event start date is required!");
            }
        }

        private void deleteFile(String filepath)
        {
            if (File.Exists(filepath) == true)
            {
                File.Delete(filepath);
            }
        }

        private void CostFormat(object sender, EventArgs e)
        {
            this.textBoxEventCost.Text = this.ConvertStringToCurrency(this.textBoxEventCost.Text);
        }

        private String ConvertStringToCurrency(String amount)
        {
            Double value;
            if (Double.TryParse(amount, out value))
            {
                return String.Format("{0:N2}", value);
            }

            return String.Empty;
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

        private DateTime ConvertStringToDate(String date)
        {
            DateTime value;
            if (DateTime.TryParse(date, out value))
            {
                return DateTime.Parse(date);
            }

            return DateTime.Now;

            //https://stackoverflow.com/questions/919244/converting-a-string-to-datetime
        }

        private void NewEventForm_Load(object sender, EventArgs e)
        {

        }

        private void discard(object sender, EventArgs e)
        {
            this.textBoxEventName.Text = String.Empty;
            this.textBoxEventLocation.Text = String.Empty;
            this.dateTimeEventFrom.Value = DateTime.Now;
            this.dateTimeEventTo.Value = DateTime.Now;
            this.textBoxEventCost.Text = String.Empty;
            this.textBoxEventDetails.Text = String.Empty;

            this.comboEventType.SelectedIndex = 0;
            this.comboEventRepeat.SelectedIndex = 0;
            this.comboEventReminder.SelectedIndex = 0;
            this.comboEventCurrency.SelectedIndex = 0;
        }
    }
}
