using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Food> Foods { get; set; } = null!;
    }
    public record RegisterCategoryRequest(string Name,List<Food> Foods);
    public record RegisterCategoryResponse(string Name);
}