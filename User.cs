﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /*
     * User Authority Levels
     */
    enum Authority
    {
        Admin,
        User,
        Part_Time_User
    }

    internal class User : Person
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password {  get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Photo {  get; set; }
        public Authority Authorisation {  get; set; }
        public IAuthorityStrategy _strategy {  get; set; }
        public PhoneBook Phonebook {  get; set; }
        public NoteBook Notebook { get; set; }

        public User() { }

        public void SetStrategy(Authority authority)
        {
            switch (authority)
            {
                case Authority.Admin:
                    this._strategy = new AdminStrategy();
                    break;

                case Authority.User:
                    this._strategy = new UserStrategy();
                    break;

                case Authority.Part_Time_User:
                    this._strategy = new PartTimeUserStrategy();
                    break;
            }
        }
    }
}
