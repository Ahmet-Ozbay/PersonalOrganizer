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
        public string Content { get; set; }
        public Reminder() { }

    }
}
