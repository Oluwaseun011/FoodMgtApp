using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Dtos;
using FoodDeliveryApp.Models.Entities;

namespace FoodDeliveryApp.Services.Interfaces
{
    public interface IUserService
    {
        BaseResponse<LoginResponseModel> Login(LoginRequestModel loginRequest);
    }
}