using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
    public record DeliveryRequest(string Name, string Email, string PlateNumber);
    public record DeliveryResponse(int Id, string Name, string Email, string PlateNumber);
}