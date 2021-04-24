using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class ExpenseCategoryModel
    {
        private ExpenseTrackerDatabaseContainer db = new ExpenseTrackerDatabaseContainer();

        public ExpenseCategoryModel()
        {
           // this.db = new ExpenseTrackerDatabaseContainer();
        }

        public Boolean AddCategory(String name)
        {
            
            // expense category name is unique
            int category = this.db.ExpenseCategories.Where(s => s.Name == name).Count();
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

        public Boolean UpdateCategory(String name, int catId)
        {

            // expense category name is unique
            int category = this.db.ExpenseCategories.Where(s => s.Name == name).Count();
            if (category > 0)
            {
                throw new Exception($"Expense category '{name}' already exists");
            }

            ExpenseCategory expenseCategory = this.db.ExpenseCategories.Find(catId);
            if (expenseCategory == null)
            {
                throw new Exception("Update error: Expense category not found!");
            }

            expenseCategory.Name = name;
            this.db.SaveChanges();

            return true;
        }

        public List<ExpenseCategory> getAll()
        {
            using (var ctx = new ExpenseTrackerDatabaseContainer())
            {
                return ctx.ExpenseCategories.ToList();
            }
        }

        public void deleteCategory(int catId)
        {
            ExpenseCategory expenseCategory = this.db.ExpenseCategories.Find(catId);
            this.db.ExpenseCategories.Remove(expenseCategory);
            this.db.SaveChanges();
        }

        public ExpenseCategory GetExpenseCategory(int catId)
        {
            ExpenseCategory category = this.db.ExpenseCategories.Find(catId);

            if (category.Id == catId)
            {
                return category;
            }

            // no match found, return null
            return null;
        }
    }
}
