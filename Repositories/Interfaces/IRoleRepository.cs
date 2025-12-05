using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        void AddToDb(Role role);
        ICollection<Role> GetRoles();
        Role? GetRole(int id);
        bool IsExist(string name);
    }
}