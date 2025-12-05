using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodDeliveryApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void AddToDb(User user);
        bool IsExist(string email);
        ICollection<User> GetUsers();
        User? GetUser(string email);
        
    }
}