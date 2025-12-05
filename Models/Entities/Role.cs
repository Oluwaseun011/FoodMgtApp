using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Models.Entities;

namespace FoodDeliveryApp.Models.Entities
{
    public class Role
    {
        public int Id {get; set;}
        public string Name {get; set;} = default!;
        public bool IsDeleted {get; set;}
        public ICollection<UserRole> UserRoles {get; set;} = new HashSet<UserRole>();

        public Role(string name)
        {
            Name = name;
        }
    }
}