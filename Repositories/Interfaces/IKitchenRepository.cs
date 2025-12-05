using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IKitchenRepository
    {
        void AddToDb(Kitchen kitchen);
        ICollection<Kitchen> GetKitchens();
        Kitchen? GetKitchen(string name);
        bool IsExist(string name);
        
    }
}