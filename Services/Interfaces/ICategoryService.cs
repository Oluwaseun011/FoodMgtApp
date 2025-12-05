using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Dtos;

namespace FoodMgtApp.Services.Interfaces
{
    public interface ICategoryService
    {
        RegisterCategoryResponse? CreateFood(RegisterCategoryRequest categoryRequest);
        Category? GetCategoryById(int Id);
        bool DeleteCategory(int id);
        public List<Category> GetAllCategory();

    }
}