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

        public PhoneBook() { }
        public PhoneBook(IDataRepository repository) {  _repository = repository; }
        public bool Add(Contact contact) { throw new NotImplementedException(); }
        public bool Update(Contact contact) { throw new NotImplementedException(); }
        public bool Delete(Contact contact) { throw new NotImplementedException(); }
        public List<Contact> List() { throw new NotImplementedException(); }
    }
}
