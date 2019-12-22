using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Interfaces
{
    public interface IUserRepository
    {
        Models.User Insert(Models.User user);
        Models.User Update(Models.User user);
        void Delete(int id);
        List<Models.User> List();
        Models.User Get(int id);
    }
}
