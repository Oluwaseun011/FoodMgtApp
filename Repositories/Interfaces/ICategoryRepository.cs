using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        bool IsExist(int kitchenId, string name);
        void Add(Category category);
        Category? GetCategory(int kitchenId, string name);
        ICollection<Category> GetKitchenCategories(int kitchenId);
    }
}