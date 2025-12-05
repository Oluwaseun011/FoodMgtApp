using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Delivery
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email {get; set; } = default!;
        public string PlateNumber { get; set; } = default!;
        public bool IsAvailable { get; set; }
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; } 

        public Delivery(string name,  string email, string plateNumber)
        {
            Name = name;
            Email = email;
            PlateNumber = plateNumber;
            IsAvailable = true;
            IsDeleted = false;
            DateCreated = DateTime.UtcNow;
        }
    }
}