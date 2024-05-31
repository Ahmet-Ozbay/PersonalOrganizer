using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class TaskReminder : IReminder
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // Implement methods for list, add, update, delete
    }
}
