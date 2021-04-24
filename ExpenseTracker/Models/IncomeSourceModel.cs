using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    class IncomeSourceModel
    {
        private ExpenseTrackerDatabaseContainer db = new ExpenseTrackerDatabaseContainer();


        public Boolean AddIncomeSource(String name)
        {

            // income source name is unique
            int source = this.db.IncomeSources.Where(s => s.Name == name).Count();
            if (source > 0)
            {
                throw new Exception($"Income source '{name}' already exists");
            }

            IncomeSource incomeSource = new IncomeSource();
            incomeSource.Name = name;
            this.db.IncomeSources.Add(incomeSource);
            this.db.SaveChanges();

            return true;
        }


        public Boolean UpdateIncomeSource(String name, int incomeId)
        {

            // expense category name is unique
            int source = this.db.IncomeSources.Where(s => s.Name == name).Count();
            if (source > 0)
            {
                throw new Exception($"Income source '{name}' already exists");
            }

            IncomeSource incomeSource = this.db.IncomeSources.Find(incomeId);
            if (incomeSource == null)
            {
                throw new Exception("Update error: Income source not found!");
            }

            incomeSource.Name = name;
            this.db.SaveChanges();

            return true;
        }

        public List<IncomeSource> getAll()
        {
            using (var ctx = new ExpenseTrackerDatabaseContainer())
            {
                return ctx.IncomeSources.ToList();
            }
        }

        public void deleteIncomeSource(int incomeId)
        {
            IncomeSource incomeSource = this.db.IncomeSources.Find(incomeId);
            this.db.IncomeSources.Remove(incomeSource);
            this.db.SaveChanges();
        }

        public IncomeSource GetIncomeSource(int incomeId)
        {
            IncomeSource incomeSource = this.db.IncomeSources.Find(incomeId);

            if (incomeSource.Id == incomeId)
            {
                return incomeSource;
            }

            // no match found, return null
            return null;
        }
    }
}

