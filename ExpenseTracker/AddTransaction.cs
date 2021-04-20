using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class AddTransaction : Form
    {
        public AddTransaction()
        {
            InitializeComponent();

            // set initial values
            this.comboTransactionCurrency.SelectedIndex = 0;
            this.comboTransactionType.SelectedIndex = 0;
            this.comboTransactionRecurrentType.SelectedIndex = 0;
        }

        private void textTransactionAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void save(object sender, EventArgs e)
        {

        }

        private void discard(object sender, EventArgs e)
        {

        }
    }
}
