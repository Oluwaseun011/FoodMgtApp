using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

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

    }

        public record KitchenRequest(string Name, string Description, Manager Manager, List<Branch> Branches);
        public record KitchenResponse(int Id, string CreatedBy, DateTime DateCreated);
        
    
}