using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    class IncomeSourceModel
    {
        private ExpenseTrackerDatabaseContainer db = new ExpenseTrackerDatabaseContainer();


        /*public bool AddIncomeSource(String name)
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
        }*/

        public async Task<Boolean> AddIncomeSourceAsync(String name)
        {

            await Task.Run(() => {

                // income source name is unique
                using (var db = new ExpenseTrackerDatabaseContainer())
                {
                    int source = db.IncomeSources.Where(s => s.Name == name).Count();
                    if (source > 0)
                    {
                        throw new Exception($"Income source '{name}' already exists");
                    }

                    IncomeSource incomeSource = new IncomeSource();
                    incomeSource.Name = name;
                    db.IncomeSources.Add(incomeSource);
                    db.SaveChanges();
                }
            });

            return true;
        }

        public async Task<Boolean> UpdateIncomeSourceAsync(String name, int incomeId)
        {

            await Task.Run(() => {

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
            });

            return true;
        }

        public List<IncomeSource> GetAll()
        {
            using (var ctx = new ExpenseTrackerDatabaseContainer())
            {
                return ctx.IncomeSources.ToList();
            }
        }

        public async Task<Boolean> DeleteIncomeSourceAsync(int incomeId)
        {
            await Task.Run(() => {
                IncomeSource incomeSource = this.db.IncomeSources.Find(incomeId);
                this.db.IncomeSources.Remove(incomeSource);
                this.db.SaveChanges();
            });

            return true;
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

