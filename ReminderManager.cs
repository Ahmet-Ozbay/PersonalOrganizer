using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class ReminderManager
    {
        private User Owner { get; set; }
        private List<Reminder> reminders { get; set; }
        private IDataRepository _repository { get; set; }

    }
}
