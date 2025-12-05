using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Dtos;

namespace FoodMgtApp.Services.Interfaces
{
    public interface IFoodService
    {
        RegisterFoodResponse? CreateFood(RegisterFoodRequest food);
        bool DeleteProduct(int id);
        public List<Food> GetAllFoods();
        Food? GetFoodById(int Id);
    }
}