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
        public string RefNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; } 
        public bool IsDeleted { get; set; }
        public ICollection<Branch> Branches { get; set; } = new HashSet<Branch>();
    }
}