using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Contact: Person
    {
        public Contact() { }
        public Contact(string name, string last_name, string phone_number, string email, string adress)
        {
            this.Name = name;
            this.LastName = last_name;
            this.PhoneNumber = phone_number;
            this.Email = email;
            this.Adress = adress;
        }
    }
}
