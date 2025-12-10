using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IFoodRepository
    {
        bool IsExist(string name);
        void Add(Food food);
        Food? GetFood(int id);
        ICollection<Food> GetAllFood();
    }
}