using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public int KitchenId { get; set; }
        public Kitchen Kitchen{get; set;} = default!;
        public string Name { get; set; } = null!;
        public ICollection<Food> Foods { get; set; } = new HashSet<Food>();  
    }
    public record RegisterCategoryRequest(int KitchenId, string Name);
    public record RegisterCategoryResponse(string Name);
}