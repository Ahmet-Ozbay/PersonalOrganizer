﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class TaskReminderFactory : IReminderFactory
    {
        public IReminder CreateMeetingReminder()
        {
            // This factory does not create Meeting Reminders.
            throw new NotImplementedException();
        }

        public IReminder CreateTaskReminder()
        {
            return new TaskReminder();
        }
    }
}