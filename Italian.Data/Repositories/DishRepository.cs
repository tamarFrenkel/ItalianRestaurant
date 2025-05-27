using Italian.Core.Models;
using Italyano.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italian.Data.Repositories
{
    public class DishRepository
    {
        private readonly DataContext _context;

        public DishRepository(DataContext context)
        {
            _context = context;
        }

        public List<Dish> GetDish()
        {
            throw new NotImplementedException();
        }

        public List<Dish> GetList()
        {
            return _context.dishes.ToList();

        }

        //public Dish AddDish(Dish dish)
        //{
        //    _context.dishes.Add(dish);
        //    _context.SaveChanges();
        //    return dish;
        //}

        //public Dish UpdateDish(int id, Dish dish)
        //{
        //    var existDish = GetById(id);

        //    existDish.FirstName = dish.FirstName;
        //    existDish.LastName = dish.LastName;

        //    _context.SaveChanges();
        //    return existDish;
        //}

        //public void DeleteUser(Dish user)
        //{
        //    var dish = GetById(id);
        //    _context.users.Remove(dish);
        //    _context.SaveChanges();
        //}

        // add , update, delete - user
    }
}
