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
        public string CreatedBy {get; set;} = default!;
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public bool IsDeleted {get; set;}
        public DateTime DateCreated {get; set;}
        public List<UserRole> UserRoles {get; set;} = new List<UserRole>();

        public record RoleRequest(string name);
        public record RoleResponse(int id, string name);

    }
}