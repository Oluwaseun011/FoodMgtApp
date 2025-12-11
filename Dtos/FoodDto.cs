using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class FoodDto
    {
        public int Id { get; set;}
        public string Name{get;set;} = null!;
        public int CategoryId{get;set;}
        public Category Category{get; set;} = default!;
        public ICollection<OrderFood> OrderFoods {get; set;} = new HashSet<OrderFood>();
    }
    public record RegisterFoodRequestModel(string Name,int CategoryId);
      
    public record RegisterFoodResponseModel(string Name);
}