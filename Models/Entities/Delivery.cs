using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Delivery
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email {get; set; } = null!;
        public string PlateNumber { get; set; } = null!;
        public bool IsAvailable { get; set; }
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;

        public Delivery(string name,  string phoneNumber, string email, string plateNumber, bool isAvailable)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            PlateNumber = plateNumber;
            IsAvailable = isAvailable;
        }
    }
}