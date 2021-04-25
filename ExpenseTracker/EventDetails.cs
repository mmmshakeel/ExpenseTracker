using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    class EventDetails
    {
        public string Name { get; set; }
        public string EventType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Location { get; set; }
        public string Repeat { get; set; }
        public string Reminder { get; set; }
        public string Currency { get; set; }
        public double Cost { get; set; }
        public string Details { get; set; }

    }
}
