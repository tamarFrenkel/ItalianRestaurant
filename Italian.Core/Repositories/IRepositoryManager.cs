using Italian.Core.Models;
using Italyano.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italian.Core.Repositories
{
    public interface IRepositoryManager
    {
        public IRepository<User> Users { get; }
        void Save();
    }
}
