using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class ExpenseCategoryModel
    {
        private ExpenseTrackerDatabaseContainer db = new ExpenseTrackerDatabaseContainer();


        public async Task<Boolean> AddCategory(String name)
        {

            // expense category name is unique
            await Task.Run(() => {

                //Thread.Sleep(5000);
                int category = this.db.ExpenseCategories.Where(s => s.Name == name).Count();
                if (category > 0)
                {
                    throw new Exception($"Expense category '{name}' already exists");
                }

                ExpenseCategory expenseCategory = new ExpenseCategory();
                expenseCategory.Name = name;
                this.db.ExpenseCategories.Add(expenseCategory);


                this.db.SaveChanges();
            });

            return true;
        }

        public async Task<Boolean> UpdateCategory(String name, int catId)
        {

            await Task.Run(() => {
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
            });

            return true;
        }

        public List<ExpenseCategory> GetAll()
        {
            using (var ctx = new ExpenseTrackerDatabaseContainer())
            {
                return ctx.ExpenseCategories.ToList();
            }
        }

        public async Task<Boolean> DeleteCategory(int catId)
        {
            await Task.Run(() => {
                ExpenseCategory expenseCategory = this.db.ExpenseCategories.Find(catId);
                this.db.ExpenseCategories.Remove(expenseCategory);
                this.db.SaveChanges();
            });

            return true;
        }

        public ExpenseCategory GetExpenseCategory(int catId)
        {
            using (var ctx = new ExpenseTrackerDatabaseContainer())
            {
                ExpenseCategory category = ctx.ExpenseCategories.Find(catId);
                return category;
            }
        }
    }
}
