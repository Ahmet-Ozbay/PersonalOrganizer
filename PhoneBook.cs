using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class PhoneBook
    {
        private User Owner {  get; set; }
        private List<Contact> Contacts { get; set; }
        private IDataRepository _repository {  get; set; }

        public PhoneBook(IDataRepository repository, User owner)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            Contacts = _repository.ListContacts(owner.Email) ?? new List<Contact>();

        }
        //public PhoneBook(IDataRepository repository) {  _repository = repository; }
        public bool Add(Contact contact, string user_email)
        {
            contact.UserEmail = user_email; // Set the user email when adding a new contact.
            var result = _repository.Add(contact);
            if (result)
            {
                Contacts.Add(contact); // Add the contact to the local list if successful.
            }
            return result;
        }
        public bool Update(Contact contact) 
        {
            // Update the contact in the repository.
            var result = _repository.Update(contact);
            if (result)
            {
                // Update the contact in the local list.
                var contactToUpdate = Contacts.FirstOrDefault(c => c.ID == contact.ID);
                if (contactToUpdate != null)
                {
                    contactToUpdate.Name = contact.Name;
                    contactToUpdate.LastName = contact.LastName;
                    contactToUpdate.PhoneNumber = contact.PhoneNumber;
                    contactToUpdate.Email = contact.Email;
                    contactToUpdate.Address = contact.Address;
                }
            }
            return result;
        }
        public bool Delete(Contact contact) 
        {
            // Delete the contact from the repository.
            var result = _repository.Delete(contact);
            if (result)
            {
                // Remove the contact from the local list.
                Contacts.RemoveAll(c => c.ID == contact.ID);
            }
            return result;
        }
        public List<Contact> List(string user_email) 
        {
            return  Contacts.Where(contact => contact.UserEmail == user_email).ToList();
        }
    }
}
