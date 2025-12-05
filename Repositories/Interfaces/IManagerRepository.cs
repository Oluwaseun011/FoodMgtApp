using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IManagerRepository
    {
        void AddToDb(Manager manager);
        bool IsExist(string email);
        Manager? GetManager(string email);
        ICollection<Manager> GetManagers();
    }
}