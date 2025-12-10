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
        bool IsExist(string name);
        void AddToDb(Role role);
        Role? GetRole(string name);
        ICollection<Role> GetRoles();
    }
}