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
        public string CreatedBy {get; set;} = default!;
        public bool IsDeleted {get; set;}
        public DateTime DateCreated {get; set;}
        public ICollection<UserRole> UserRoles {get; set;} = new HashSet<UserRole>();
    

        public User(string email, string password, string createdBy)
        {
            Email = email;
            Password = password; 
            CreatedBy = createdBy; 
            DateCreated = DateTime.UtcNow;
        }

       
    }
}