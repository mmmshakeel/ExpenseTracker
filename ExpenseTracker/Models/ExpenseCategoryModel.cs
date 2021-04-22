using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class ExpenseCategoryModel
    {
        private ExpenseTrackerDatabaseContainer db;

        public ExpenseCategoryModel()
        {
            this.db = new ExpenseTrackerDatabaseContainer();
        }

        public Boolean AddCategory(String name)
        {
            
            // expense category name is unique
            var category = this.db.ExpenseCategories.Where(s => s.Name == name).Count();
            if (category > 0)
            {
                throw new Exception($"Expense category '{name}' already exists");
            }

            ExpenseCategory expenseCategory = new ExpenseCategory();
            expenseCategory.Name = name;
            this.db.ExpenseCategories.Add(expenseCategory);
            this.db.SaveChanges();

            return true;
        }
    }
}
