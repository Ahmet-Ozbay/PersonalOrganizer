using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Reminder
    {
        public int ID { get; set; }
        public string UserEmail { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime ReminderDate { get; set; }
        public TimeSpan ReminderTime { get; set; }
        public Reminder() { }

    }
}
