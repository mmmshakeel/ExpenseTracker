using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    class TransactionDetails
    {
        public DateTime date { get; set; }
        public string details { get; set; }
        public string currency { get; set; }
        public double amount { get; set; }
        public string type { get; set; }
        public string category { get; set; }
        public string recurrence { get; set; }

    }
}
