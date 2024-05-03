using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class AdminStrategy : IAuthorityStrategy
    {
        public bool AddContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public bool AddNote(Note note)
        {
            throw new NotImplementedException();
        }

        public bool ChangeEmail(string new_email)
        {
            throw new NotImplementedException();
        }

        public bool ChangeLastName(string new_last_name)
        {
            throw new NotImplementedException();
        }

        public bool ChangeName(string new_name)
        {
            throw new NotImplementedException();
        }

        public bool ChangePassword(string new_password)
        {
            throw new NotImplementedException();
        }

        public bool ChangePhoto(string new_photo)
        {
            throw new NotImplementedException();
        }

        public bool ChangeUserAuthority(Authority authority)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<Contact> ListContact()
        {
            throw new NotImplementedException();
        }

        public List<Note> ListNote()
        {
            throw new NotImplementedException();
        }

        public bool RemoveContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public bool RemoveNote(Note note)
        {
            throw new NotImplementedException();
        }

        public bool ResetUserPassword(User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNote(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
