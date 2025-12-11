using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Dtos;
using FoodDeliveryApp.Models.Entities;
using FoodDeliveryApp.Repositories.Implementations;
using FoodDeliveryApp.Repositories.Interfaces;
using FoodDeliveryApp.Services.Interfaces;

namespace FoodDeliveryApp.Services.Implementations
{
    public class UserService : IUserService
    {
        IUserRepository userRepository = new UserRepository();
        IUserRoleRepository userRoleRepository = new UserRoleRepository();

        public BaseResponse<LoginResponseModel> Login(LoginRequestModel loginRequest)
        {
            var emailExist = userRepository.GetUser(loginRequest.Email);
            if(emailExist is null)
            {
                return new BaseResponse<LoginResponseModel>
                {
                    Status = false,
                    Message = "invalid cridentials",
                    Data = null
                };
            }
            if(!BCrypt.Net.BCrypt.Verify(loginRequest.Password, emailExist.Password))
            {
                return new BaseResponse<LoginResponseModel>
                {
                    Status =false,
                    Message = "invalid cridentials",
                    Data = null
                };
            }
            var userRoles = userRoleRepository.Get(emailExist.Id);
            var roles = new List<Role>();
            foreach (var item in userRoles)
            {
                var role = new Role
                {
                    Id = item.Id,
                    Name = item.
                }
            }
            return new BaseResponse<LoginResponseModel>
            {
                Status = true,
                Message = "login successful",
                Data = new LoginResponseModel
                {
                    Email = emailExist.Email,
                    Roles = 
                }
            };
        }
    }
}