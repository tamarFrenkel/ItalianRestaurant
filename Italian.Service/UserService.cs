using Italian.Core.Models;
using Italian.Core.Repositories;
using Italian.Core.Services;
using Italian.Data.Repositories;
using Italyano.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Italian.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepositoryManager _repositoryManager;

        public UserService(IRepository<User> userRepository, IRepositoryManager repositoryManager)
        {
            _userRepository = userRepository;
            _repositoryManager = repositoryManager;
        }

        public List<User> GetAll()
        {
            // להוסיף לוגיקה עסקית.
            return _userRepository.GetAll().ToList();
        }

        public User Add(User user) 
        { 
            var res = _userRepository.Add(user);
            _repositoryManager.Save();
            return res;
        }

        public User Update(User user) 
        { 
            var res = _userRepository.Update(user);
            _repositoryManager.Save();
            return res;
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
            _repositoryManager.Save();
        }
    }
}
