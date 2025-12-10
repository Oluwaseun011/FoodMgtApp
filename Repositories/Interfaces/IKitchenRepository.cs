using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IKitchenRepository
    {
        bool IsExist(string name);
        void Add(Kitchen kitchen);
        Kitchen? Get(string name);
        ICollection<Kitchen> GetAll();   
    }
}