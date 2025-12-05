using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class BranchManagerDto
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
    public record RegisterManagerRequest(string Name,string Email,Kitchen Kitchen);
    public record RegisterManagerResponse(string Name,Kitchen Kitchen);
}