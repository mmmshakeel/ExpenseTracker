using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class MainForm : Form
    {
        private Boolean financeLeftPaneAdded = false;
        private Boolean eventsLeftPaneAdded = false;
        private Boolean newTransactionFormAdded = false;
        private Boolean newEventFormAdded = false;

        private FinanceLeftPaneForm financeLeftPaneForm;
        private EventsLeftPaneForm eventsLeftPaneForm;
        private AddTransaction newTransactionForm;
        private AddEvent newEventForm;
        private ShowTransactionsList transactionsListForm;
        private ShowIncomeSources incomeSourcesForm;
        private ShowExpenseCategories expenseCategoriesForm;
        private ShowEvents showEventsForm;

        public MainForm()
        {
            InitializeComponent();

            // add the Finance left pane as default
            this.financeLeftPaneForm = new FinanceLeftPaneForm();
            this.financeLeftPaneForm.TopLevel = false;
            this.financeLeftPaneForm.FormBorderStyle = FormBorderStyle.None;
            this.leftPanel.Controls.Add(this.financeLeftPaneForm);
            this.financeLeftPaneForm.Show();
            this.financeLeftPaneAdded = true;

            // prepare for transactions left menu item click
            this.transactionsListForm = new ShowTransactionsList();
            this.transactionsListForm.TopLevel = false;
            this.transactionsListForm.FormBorderStyle = FormBorderStyle.None;
            this.rightPanel.Controls.Add(this.transactionsListForm);
            this.financeLeftPaneForm.TransactionsListForm = this.transactionsListForm;

            // prepare for income sources left menu item click
            this.incomeSourcesForm = new ShowIncomeSources();
            this.incomeSourcesForm.TopLevel = false;
            this.incomeSourcesForm.FormBorderStyle = FormBorderStyle.None;
            this.rightPanel.Controls.Add(this.incomeSourcesForm);
            this.financeLeftPaneForm.IncomeSourcesForm = this.incomeSourcesForm;

            // prepare for expense categories left menu item click
            this.expenseCategoriesForm = new ShowExpenseCategories();
            this.expenseCategoriesForm.TopLevel = false;
            this.expenseCategoriesForm.FormBorderStyle = FormBorderStyle.None;
            this.rightPanel.Controls.Add(this.expenseCategoriesForm);
            this.financeLeftPaneForm.ExpenseCategoriesForm = this.expenseCategoriesForm;

            // load new transaction as default to right pane
            this.newTransactionForm = new AddTransaction();
            this.newTransactionForm.TopLevel = false;
            this.newTransactionForm.FormBorderStyle = FormBorderStyle.None;
            this.rightPanel.Controls.Add(this.newTransactionForm);
            this.newTransactionForm.Show();
            this.newTransactionFormAdded = true;
            this.financeLeftPaneForm.AddTransactionForm = this.newTransactionForm;

            /* ================ events left pane forms ================ */
            // load the Events left pane to load when button click
            this.eventsLeftPaneForm = new EventsLeftPaneForm();
            this.eventsLeftPaneForm.TopLevel = false;
            this.eventsLeftPaneForm.FormBorderStyle = FormBorderStyle.None;

            // load new event form
            this.newEventForm = new AddEvent();
            this.newEventForm.TopLevel = false;
            this.newEventForm.FormBorderStyle = FormBorderStyle.None;
            this.eventsLeftPaneForm.AddEventForm = this.newEventForm;

            // load show events form for appointments and tasks label click
            this.showEventsForm = new ShowEvents();
            this.showEventsForm.TopLevel = false;
            this.showEventsForm.FormBorderStyle = FormBorderStyle.None;
            this.rightPanel.Controls.Add(this.showEventsForm);
            this.eventsLeftPaneForm.ShowEventsForm = this.showEventsForm;
            
            
           

        }

        private void eventsButton_Click(object sender, EventArgs e)
        {

            if (this.eventsLeftPaneAdded)
            {
                this.eventsLeftPaneForm.BringToFront();
            } else
            {
                this.leftPanel.Controls.Add(this.eventsLeftPaneForm);
                this.eventsLeftPaneForm.Activate();
                this.eventsLeftPaneForm.Show();
                this.eventsLeftPaneAdded = true;
            }

            if (this.newEventFormAdded)
            {
                this.newEventForm.BringToFront();
            } else
            {
                this.rightPanel.Controls.Add(this.newEventForm);
                this.eventsLeftPaneForm.Activate();
                this.newEventForm.Show();
                this.newEventFormAdded = true;
            }
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            if (this.financeLeftPaneAdded)
            {
                this.financeLeftPaneForm.BringToFront();
            } else
            {
                this.leftPanel.Controls.Add(this.financeLeftPaneForm);
                this.financeLeftPaneForm.Activate();
                this.financeLeftPaneForm.Show();
                this.financeLeftPaneAdded = true;
            }

            if (this.newTransactionFormAdded)
            {
                this.newTransactionForm.BringToFront();
            } else
            {
                this.rightPanel.Controls.Add(this.newTransactionForm);
                this.newTransactionForm.Activate();
                this.newTransactionForm.Show();
                this.newTransactionFormAdded = true;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
