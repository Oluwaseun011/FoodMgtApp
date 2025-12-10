using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Dtos;
using FoodDeliveryApp.Repositories.Implementations;
using FoodDeliveryApp.Repositories.Interfaces;
using FoodDeliveryApp.Services.Interfaces;

namespace FoodDeliveryApp.Services.Implementations
{
    public class UserService : IUserService
    {
        IUserRepository userRepository = new UserRepository();
        public LoginResponse? Login(LoginRequest loginRequest)
        {
            
        }
    }
}