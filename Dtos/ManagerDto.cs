using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class ManagerDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int KitchenId { get; set; }
        public Kitchen Kitchen { get; set; }= default!;
        public string CreatedBy { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }

    }

    public record ManagerRequest(string Email, string Name, Kitchen Kitchen, int KitchenId);
    public record ManagerResponse(int Id, int KitchenId, string Name, string Email, string CreatedBy, DateTime DateCreated);

}