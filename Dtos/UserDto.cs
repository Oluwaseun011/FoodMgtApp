using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Models.Entities;

namespace FoodDeliveryApp.Dtos
{
    public class UserDto
    {
        public int Id{get; set;}
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public List<UserRole> UserRoles {get; set;} = new List<UserRole>();
    }

    public class LoginRequest
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public LoginRequest(string email,string password)
        {
            Email = email;
            Password = password;
        }
    }

     public class LoginResponse
    {
    
        public int Id{ get; set; }
        public string Email{ get; set; } = default!;
        public List<UserRole> UserRoles = new List<UserRole>();
    }
}