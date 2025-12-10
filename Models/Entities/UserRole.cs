using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Models.Entities
{
    public class UserRole
    {
        public int Id{get; set;}
        public int UserId{get; set;}
        public User User{get; set;} = default!;
        public int RoleId{get; set;}
        public Role Role{get; set;} = default!;
    }
}