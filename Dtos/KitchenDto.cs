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
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; } 
        public bool IsDeleted { get; set; }
        public Manager Manager { get; set; } = default!;
        public List<Branch> Branches { get; set; } = new List<Branch>();
        public string Email { get; set; } = default!;
        public int KitchenId { get; set; }
        public Kitchen Kitchen { get; set; }= default!;
        public string Password {get; set;} = default!;
        public List<UserRole> UserRoles {get; set;} = new List<UserRole>();
    

    }

        public record KitchenRequest(string Name, string Email, string Password, string Description);
        public record KitchenResponse(int Id, string Name, string Email, string Description);
        
    
}