using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class TaskReminderFactory : IReminderFactory
    {
        public IReminder CreateReminder()
        {
            return new TaskReminder();
        }
    }
}