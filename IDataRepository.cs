using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal interface IDataRepository
    {
        bool Add(User user);
        bool Add(Note note);
        bool Update(User user);
        bool Update (Note note);
        bool Delete(User user);
        bool Delete(Note note);
        List<User> List();
        List<Note> ListNotes();
    }
}
