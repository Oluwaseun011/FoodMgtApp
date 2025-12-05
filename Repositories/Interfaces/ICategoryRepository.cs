using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        bool IsExist(string categoryName);
        Category? GetCategory(int id);
        List<Category> GetAllCategories();
    }
}