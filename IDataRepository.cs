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
        bool Add(Contact contact);
        bool Update(User user);
        bool Update (Note note);
        bool Update(Contact contact);
        bool Delete(User user);
        bool Delete(Note note);
        bool Delete(Contact contact);
        List<User> List();
        List<Note> ListNotes();
        List<Contact> ListContacts(string userEmail);
    }
}
