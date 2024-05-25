using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class MeetingReminderFactory : IReminderFactory
    {
        public Reminder CreateReminder()
        {
            return new MeetingReminder();
        }
    }
}
