using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Manager
    {
        public int Id { get; set; }
        public string Email { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int KitchenId { get; set; }
        public Kitchen Kitchen { get; set; }= default!;
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }

        public Manager(string name,string email, int kitchenId, string createdBy)
        {
            Name = name;
            Email = email;
            KitchenId = kitchenId;
            CreatedBy = createdBy;
            DateCreated = DateTime.UtcNow;
            IsDeleted = false;
        }
    }
}