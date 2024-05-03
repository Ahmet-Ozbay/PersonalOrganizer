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
        bool Update(User user);
        bool Delete(User user);
        List<User> List();
    }
}
