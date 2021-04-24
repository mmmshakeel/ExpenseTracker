using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.CustomElements;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    public partial class ExpenseCategoryRow : UserControl
    {

        ExpenseCategoryModel expenseCategoryModel = new ExpenseCategoryModel();


        public ExpenseCategoryRow()
        {
            InitializeComponent();
        }

        public void SetExpenseCategoryLabel(String name)
        {
            this.labelExpenseCategoryName.Text = name;
        }

        public void SetButtonId(int Id)
        {
            this.buttonEditCategory.Id = Id;
            this.buttonDeleteCategory.Id = Id;
        }

        public void SetBackColor()
        {
            this.BackColor = Color.AliceBlue;
        }

        public void SetDeleteEventHandler(EventHandler clickEvent)
        {
            this.buttonDeleteCategory.Click += new System.EventHandler(clickEvent);
        }

        public void SetEditEventHandler(EventHandler clickEvent)
        {
            this.buttonEditCategory.Click += new System.EventHandler(clickEvent);
        }
    }
}
