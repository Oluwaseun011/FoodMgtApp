using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Repositories.Interfaces;
using FoodMgtApp.Models.Entities;

namespace FoodDeliveryApp.Repositories.Implementations
{
    public class UserRoleRepository : IUserRoleRepository
    {
        public void Add(UserRole userRole)
        {
            throw new NotImplementedException();
        }

        public ICollection<UserRole> Get(int userId)
        {
            throw new NotImplementedException();
        }
    }
}