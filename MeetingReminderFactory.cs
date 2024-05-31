using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class MeetingReminderFactory : IReminderFactory
    {
        public IReminder CreateMeetingReminder()
        {
            return new MeetingReminder();
        }

        public IReminder CreateTaskReminder()
        {
            // This factory does not create Task Reminders.
            return new TaskReminder();
        }
    }
}
