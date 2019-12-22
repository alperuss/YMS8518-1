using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models;

namespace WebApi2.Services
{
    public class UserRepository : Interfaces.IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Delete(int id)
        {
            Models.User user = Get(id);
            _dataContext.Users.Remove(user);
            _dataContext.SaveChanges();
        }

        public User Get(int id)
        {
            return _dataContext.Users.Find(id);
        }

        public User Insert(User user)
        {
            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();
            return user;
        }

        public List<User> List()
        {
            return _dataContext.Users.ToList();
        }

        public User Update(User user)
        {
            _dataContext.Users.Update(user);
            _dataContext.SaveChanges();
            return user;
        }
    }
}
