using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Models.Entities;

namespace FoodDeliveryApp.Repositories.Interfaces
{
    public interface IUserRoleRepository
    {
        void Add(UserRole userRole);
        ICollection<UserRole> Get(int userId);
    }
}