using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class KitchenDto
    {
        public int UserId {get; set;}
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public ICollection<UserRole> UserRoles {get; set;} = new HashSet<UserRole>();  

        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string RefNumber { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; } 
        public bool IsDeleted { get; set; }
        public ICollection<Branch> Branches { get; set; } = new HashSet<Branch>();

    }

        public record RegisterKitchenRequestModel(string Email, string Password,string Name, string PhoneNumber);
        public record RegisterKitchenResponseModel(string Name);
        
    
}