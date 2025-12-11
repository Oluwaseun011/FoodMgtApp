using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public Category? GetCategory(int kitchenId, string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Category> GetKitchenCategories(int kitchenId)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(int kitchenId, string name)
        {
            throw new NotImplementedException();
        }
    }
}