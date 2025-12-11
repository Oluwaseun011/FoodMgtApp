using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class DeliveryDto
    {
        public int UserId {get; set;}
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public ICollection<UserRole> UserRoles {get; set;} = new HashSet<UserRole>();  

        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string PlateNumber { get; set; } = default!;
        public bool IsAvailable { get; set; }
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; } 
        public ICollection<Order> Orders = new HashSet<Order>();
    }
    public record RegisterDeliveryRequestModel(string Email, string Password, string Name,  string PlateNumber);
    public record RegisterDeliveryResponseModel(string Name);
}