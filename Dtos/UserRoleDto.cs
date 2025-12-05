using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Dtos
{
    public class UserRoleDto
    {
        public int Id{get; set;}
        public int UserId{get; set;}
        public int RoleId{get; set;}
        public User User{get; set;} = default!;
        public Role Role{get; set;} = default!;
    }
    
        public record UserRoleRequest(User User, Role Role);
        public record UserRoleResponse(int Id, int UserId, int RoleId);
       
    

}