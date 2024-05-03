using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class SignInService
    {
        private IDataRepository _repository {  get; set; }
        public SignInService(IDataRepository repository) {
        this._repository = repository;
        }
        public bool SignIn(User user)
        {
            var users = _repository.List();

            if (users.Any(u => u.Email == user.Email && u.Password == user.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
