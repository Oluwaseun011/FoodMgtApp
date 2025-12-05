using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Models.Entities;

namespace FoodDeliveryApp.Models.Entities
{
    public class User
    {
        public int Id {get; set;}
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public List<UserRole> UserRoles {get; set;} = new List<UserRole>();
    

        public User(string email, string password, string roleId)
        {
            Email = email;
            Password = password;
            
        }
    }
}