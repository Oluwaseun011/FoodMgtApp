using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int KitchenId { get; set; }
        public List<Food> Foods { get; set; } = default!;
    }
    public record RegisterCategoryRequest(int KitchenId, string Name);
    public record RegisterCategoryResponse(int Id,string Name);
}