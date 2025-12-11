using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class FoodRepository : IFoodRepository
    {
        public void Add(Food food)
        {
            throw new NotImplementedException();
        }

        public ICollection<Food> GetAllFood(int kitchenId)
        {
            throw new NotImplementedException();
        }

        public Food? GetFood(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(int kitchenId, string name)
        {
            throw new NotImplementedException();
        }
    }
}