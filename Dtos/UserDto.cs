using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Entities;

namespace FoodDeliveryApp.Dtos
{
    public class UserDto
    {
         public int Id {get; set;}
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public string CreatedBy {get; set;} = default!;
        public bool IsDeleted {get; set;}
        public DateTime DateCreated {get; set;}
        public ICollection<UserRole> UserRoles {get; set;} = new HashSet<UserRole>(); 
    }

    public record LoginRequestModel(string Email, string Password);
    public record LoginResponseModel(string Email, ICollection<Role> Roles);

}