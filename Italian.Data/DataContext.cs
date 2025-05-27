using Italian.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italyano.Data
{
    public class DataContext:DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Custumer> custumers { get; set; }
        public DbSet<Dish> dishes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }    


    }
}
