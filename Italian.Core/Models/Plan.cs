using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italian.Core.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public double Price {  get; set; }
        public required List<User> Users { get; set; }
    }
}
