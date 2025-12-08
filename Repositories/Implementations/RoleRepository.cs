using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;

namespace FoodMgtApp.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        public void AddToDb(Role role)
        {
            throw new NotImplementedException();
        }

        public Role? GetRole(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Role> GetRoles()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string name)
        {
            throw new NotImplementedException();
        }
    }
}