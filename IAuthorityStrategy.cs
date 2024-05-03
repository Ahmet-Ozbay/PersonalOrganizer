using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal interface IAuthorityStrategy
    {
        // Kullanıcının gerçekleştirebileceği metodları burada tanımla,
        // AdminStrategy, UserStrategy ve PartTimeUserStrategy classlarında implemente et
        // Aşağıdaki metodlar örnek, bunlar değişebilir.

        // Personal Information Methods
        bool ChangeName(string new_name);
        bool ChangeLastName(string new_last_name);
        bool ChangePassword(string new_password);
        bool ChangeEmail(string new_email);
        bool ChangePhoto(string new_photo);
        
        // Phonebook Methods
        bool AddContact(Contact contact);
        bool RemoveContact(Contact contact);
        bool UpdateContact(Contact contact);
        List<Contact> ListContact();

        // Notebook Methods
        bool AddNote(Note note);
        bool RemoveNote(Note note);
        bool UpdateNote(Note note);
        List<Note> ListNote();

        // Admin Methods
        bool ChangeUserAuthority(Authority authority);
        bool DeleteUser(User user);
        bool ResetUserPassword(User user);

    }
}
