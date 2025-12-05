using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Dtos;

namespace FoodMgtApp.Services.Interfaces
{
    public interface ICustomerService
    {
        LoginResponse Register(LoginRequest request);
        
    }
}