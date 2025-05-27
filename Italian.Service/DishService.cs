using Italian.Core.Models;
using Italian.Data.Repositories;
using Italyano.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Italian.Service
{
    public class DishService
    {
        private readonly DishRepository _dishRepository;

        public DishService(DishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }

        public List<Dish> GetAll()
        {
            // להוסיף לוגיקה עסקית.
            return _dishRepository.GetDish();
        }
    }
}
