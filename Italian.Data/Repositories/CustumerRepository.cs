using Italian.Core.Models;
using Italyano.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italyano.Data.Repositories
{
    public class CustumerRepository
    {
        private readonly DataContext _context;

        public CustumerRepository(DataContext context)
        {
            _context = context;
        }

        public List<Custumer> GetCustumer()
        {
            return _context.custumers.ToList();

        }

        //public Custumer AddCustumer(Custumer custumer)
        //{
        //    _context.users.Add(custumer);
        //    _context.SaveChanges();
        //    return custumer;
        //}

        //public User UpdateUser(int id, User user)
        //{
        //    var existUser = GetById(id);

        //    existUser.FirstName = user.FirstName;
        //    existUser.LastName = user.LastName;

        //    _context.SaveChanges();
        //    return existUser;
        //}

        //public void DeleteUser(User user)
        //{
        //    var user = GetById(id);
        //    _context.users.Remove(user);
        //    _context.SaveChanges();
        //}

        // add , update, delete - user
    }
}
