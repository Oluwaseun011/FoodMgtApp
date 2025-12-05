using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Kitchen
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; } 
        public bool IsDeleted { get; set; }
        public Manager Manager { get; set; } = default!;
        public ICollection<Branch> Branches { get; set; } = new HashSet<Branch>();

        public Kitchen(string name, string description,  string createdBy)
        {
            Name = name;
            Description = description;
            CreatedBy = createdBy;
            DateCreated = DateTime.UtcNow;
        }
    }
}