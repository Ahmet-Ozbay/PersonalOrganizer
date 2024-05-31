using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ReminderFactory : IReminderFactory
    {
        public IReminder CreateMeetingReminder()
        {
            return new MeetingReminder();
        }

        public IReminder CreateTaskReminder()
        {
            return new TaskReminder();
        }
    }
}
