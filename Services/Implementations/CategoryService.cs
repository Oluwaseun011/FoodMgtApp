using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Dtos;
using FoodMgtApp.Repositories.Implementations;
using FoodMgtApp.Repositories.Interfaces;
using FoodMgtApp.Services.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository categoryRepository = new CategoryRepository();
        public RegisterCategoryResponse? CreateFood(RegisterCategoryRequest categoryRequest)
        {
            var category = new Category(categoryRequest.KitchenId,categoryRequest.Name);
            categoryRepository.Add(category);
            return new RegisterCategoryResponse(category.Id,category.Name);
        }
        FoodContext foodcontext = new FoodContext();
        public bool DeleteCategory(int id)
        {
            var con = foodcontext.CreateConnection();
            {
                var qry = "delete from categories where Id = @Id";
                using (var command = new MySqlCommand(qry, con))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    var result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        public List<Category> GetAllCategory()
        {
            List<Category> categories = [];
            foreach(var category in categoryRepository.GetAllCategories())
            {
                categories.Add(category);
            }
            return categories;
        }

        public Category? GetCategoryById(int Id)
        {
            return categoryRepository.GetCategory(Id);
        }
    }
}