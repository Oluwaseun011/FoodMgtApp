using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodDeliveryApp.Services.Interfaces
{
    public interface IUserService
    {
        LoginResponse? Login(LoginRequest loginRequest);
    }

}