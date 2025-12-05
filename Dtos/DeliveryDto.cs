using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class DeliveryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email {get; set; } = default!;
        public string PlateNumber { get; set; } = default!;
        public bool IsAvailable { get; set; }
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; } 
        public string Password {get; set;} = default!;
        public List<UserRole> UserRoles {get; set;} = new List<UserRole>();
    }
    public record DeliveryRequest(string Name, string Email, string PlateNumber, string Password);
    public record DeliveryResponse(int Id, string Email, string PlateNumber);
}