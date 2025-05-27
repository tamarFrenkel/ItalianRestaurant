using Italian.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italian.Core.Services
{
    public interface IUserService
    {
        public List<User> GetAll();
    }
}

