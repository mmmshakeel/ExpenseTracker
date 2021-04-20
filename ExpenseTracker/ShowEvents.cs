using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class ShowEvents : Form
    {
        public ShowEvents()
        {
            InitializeComponent();
        }

        public void UpdateFormHeading(object sender)
        {
            this.labelEventType.Text = ((Label)sender).Text;
        }
    }
}
