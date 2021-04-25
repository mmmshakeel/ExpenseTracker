using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    class EventModel
    {

        private ExpenseTrackerDatabaseContainer db = new ExpenseTrackerDatabaseContainer();

        public bool AddEvent(EventDetails eventDetails)
        {
            Event newEvent = new Event();

            newEvent.Name = eventDetails.Name;
            newEvent.EventType = eventDetails.EventType;
            newEvent.Location = eventDetails.Location;
            newEvent.From = eventDetails.From;
            newEvent.To = eventDetails.To;
            newEvent.Repeat = eventDetails.Repeat;
            newEvent.Reminder = eventDetails.Reminder;
            newEvent.Details = eventDetails.Details;
            newEvent.Currency = eventDetails.Currency;
            newEvent.Cost = eventDetails.Cost;

            this.db.Events.Add(newEvent);
            this.db.SaveChanges();
            return true;
        }
    }
}
