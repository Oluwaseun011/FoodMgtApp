using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IFoodRepository
    {
        void Add(Food food);
        bool IsExist(string foodName);
        Food? GetFood(int id);
        List<Food> GetAllFood();
    }
}