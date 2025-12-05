using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using static FoodMgtApp.Dtos.RoleDto;

namespace FoodMgtApp.Services.Interfaces
{
    public interface IRoleService
    {
        RoleResponse? Create(RoleRequest roleRequest);
        Role? GetRole(int id);
        ICollection<Role> GetRoles();
    }
}