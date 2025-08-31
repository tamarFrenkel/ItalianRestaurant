using Italian.Core.Models;
using Italyano.Core.Repositories;
using Italyano.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italian.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext context): base(context) 
        {
        }

        public User GetByUserNamePassword(string userName, string password)
        {
            return this._dbSet.Where(u => u.FirstName == userName && u.Password == password).FirstOrDefault();
        }

        public IEnumerable<User> GetList()
        {
            return _context.User.Include(u => u.Plan);
        }
     }
}


/*
        public List<User> GetUsers()
        {
            return _context.users.ToList();

        }

        public User AddUser(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User UpdateUser(int id, User user)
        {
            var existUser = GetById(id);

            existUser.firstName = user.firstName;
            existUser.lastName = user.lastName;

            _context.SaveChanges();
            return existUser;
        }

        public void DeleteUser(int id)
        {
            var user = GetById(id);
            _context.users.Remove(user);
            _context.SaveChanges();
        }

        public void DeleteUserr(int id)
        {
            throw new NotImplementedException();
        }
        // add , update, delete - user
        */