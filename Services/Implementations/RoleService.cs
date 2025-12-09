using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Dtos;
using FoodMgtApp.Repositories.Implementations;
using FoodMgtApp.Repositories.Interfaces;
using FoodMgtApp.Services.Interfaces;
using Org.BouncyCastle.Asn1.X509;

namespace FoodMgtApp.Services.Implementations
{
    public class RoleService : IRoleService
    {
        IRoleRepository roleRepository = new RoleRepository();
        public RoleDto.RoleResponse? Create(RoleDto.RoleRequest roleRequest)
        {
            var exist = roleRepository.IsExist(roleRequest.name);
            if (exist) return null;

            var role = new Role
            {
                Name = roleRequest.name,
            
            };
           roleRepository.AddToDb(role);
           return new RoleDto.RoleResponse()
        }

        public Role? GetRole(int id)
        {
            var role = roleRepository.GetRole(id);
            if (role is null)
            {
                return null;
            }
            return new RoleDto.RoleResponse(role.Id, role.Name);
        }

        public ICollection<Role> GetRoles()
        {
            throw new NotImplementedException();
        }
    }
}