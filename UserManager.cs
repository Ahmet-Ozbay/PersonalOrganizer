using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class UserManager
    {
        private List<User> Users { get; set; }
        private IDataRepository _repository { get; set; }

        public UserManager(IDataRepository repository)
        {
            _repository = repository;
            Users = _repository.ListUsers(); // Load users from the repository.
        }

        public bool Add(User user)
        {
            // Add the user to the repository.
            var result = _repository.Add(user);
            if (result)
            {
                Users.Add(user); // Add the user to the local list if successful.
            }
            return result;
        }

        public bool Update(User user)
        {
            // Update the user in the repository.
            var result = _repository.Update(user);
            if (result)
            {
                // Update the user in the local list.
                var userToUpdate = Users.FirstOrDefault(u => u.ID == user.ID);
                if (userToUpdate != null)
                {
                    userToUpdate.Name = user.Name;
                    userToUpdate.LastName = user.LastName;
                    userToUpdate.Email = user.Email;
                    userToUpdate.Password = user.Password;
                    userToUpdate.Avatar = user.Avatar;
                    userToUpdate.PhoneNumber = user.PhoneNumber;
                    userToUpdate.Address = user.Address;
                    userToUpdate.Salary = user.Salary;
                    userToUpdate.Authorisation = user.Authorisation;
                    userToUpdate.SetStrategy(user.Authorisation);
                }
            }
            return result;
        }

        public bool Delete(User user)
        {
            // Delete the user from the repository.
            var result = _repository.Delete(user);
            if (result)
            {
                // Remove the user from the local list.
                Users.RemoveAll(u => u.ID == user.ID);
            }
            return result;
        }
    }
}
