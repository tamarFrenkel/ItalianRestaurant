using Italian.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italyano.Core.Repositories
{
    public interface IDishRepository
    {
        public List<User> GetUsers();
        public void AddUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(int id);

    }
}
