using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Italian.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PlanId {  get; set; }
        public Plane Plane { get; set; }
        public UserSetting userSetting { get; set; }
        public List<Team> Teams { get; set; }
    }
}
