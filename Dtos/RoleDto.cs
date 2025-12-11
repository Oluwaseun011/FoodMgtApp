using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class RoleDto
    {
        public int Id {get; set;}
        public string Name {get; set;} = default!;
        public ICollection<UserRole> UserRoles {get; set;} = new HashSet<UserRole>();
    }
    public record CreateRoleRequestModel(string Name);
    public record CreateRoleResponseModel(string Name);
}