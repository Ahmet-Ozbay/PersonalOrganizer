using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface IReminder
    {
        DateTime Date { get; set; }
        TimeSpan Time { get; set; }
        string Title { get; set; }
        string Summary { get; set; }
        string Description { get; set; }
        // Methods for list, add, update, delete
    }
}
