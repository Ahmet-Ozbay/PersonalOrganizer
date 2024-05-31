using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ReminderManager
    {
        private List<IReminder> _reminders;
        private IDataRepository _repository;
        private IReminderFactory _reminderFactory;

        public ReminderManager(IDataRepository repository, IReminderFactory reminderFactory)
        {
            _repository = repository;
            _reminderFactory = reminderFactory;
            _reminders = _repository.ListReminders();
        }


        public IReminder CreateReminder(string type)
        {
            if (type == "Meeting")
            {
                return _reminderFactory.CreateMeetingReminder();
            }
            else if (type == "Task")
            {
                return _reminderFactory.CreateTaskReminder();
            }
            else
            {
                throw new ArgumentException("Invalid reminder type.");
            }
        }

        public List<IReminder> ListReminders(string userEmail)
        {
            return _repository.ListReminders().Where(reminder => reminder.UserEmail == userEmail).ToList();

        }

        public bool AddReminder(IReminder reminder)
        {
            if (_repository.Add(reminder))
            {
                _reminders.Add(reminder);
                return true;
            }
            return false;
        }

        public bool UpdateReminder(IReminder reminder)
        {
            if (_repository.Update(reminder))
            {
                var index = _reminders.FindIndex(r => r.ID == reminder.ID);
                if (index != -1)
                {
                    _reminders[index] = reminder;
                    return true;
                }
            }
            return false;
        }

        public bool DeleteReminder(IReminder reminder)
        {
            if (_repository.Delete(reminder))
            {
                _reminders.RemoveAll(r => r.ID == reminder.ID);
                return true;
            }
            return false;
        }
    }
}
