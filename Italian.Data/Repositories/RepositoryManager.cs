using Italian.Core.Models;
using Italian.Core.Repositories;
using Italyano.Core.Repositories;
using Italyano.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italian.Data.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        public IRepository<User> Users { get; }

        public RepositoryManager(DataContext context, IRepository<User> userRepository)
        {
            _context = context;
            Users = userRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
