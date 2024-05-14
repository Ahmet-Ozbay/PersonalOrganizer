using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class SignUpService
    {
        private IDataRepository _repository {  get; set; }
        public SignUpService(IDataRepository repository) {
        this._repository = repository;
        }
        public bool SignUp(User user) {
            // Get a list of all users
            var users = _repository.List();

            // If no users in the database, first user will be Administrator
            if (!users.Any())
            {
                user.Authorisation = Authority.Admin;
            }
            else
            {
                // Every other registrant will be User, unless changed by Admin
                user.Authorisation = Authority.User;
            }

            user.PhoneNumber = null;
            user.Address = null;

            // Make sure there's only one user using the same email
            if (users.Any(u => u.Email == user.Email))
            {
                // Don't register if email is already in use
                return false;
            }

            // Add the user to the database
            return _repository.Add(user);
        }
    }
}
