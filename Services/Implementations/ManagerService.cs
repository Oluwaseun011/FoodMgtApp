using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Dtos;
using FoodMgtApp.Repositories.Implementations;
using FoodMgtApp.Repositories.Interfaces;
using FoodMgtApp.Services.Interfaces;

namespace FoodMgtApp.Services.Implementations
{
    public class ManagerService : IManagerService
    {
        IManagerRepository managerRepository = new ManagerRepository();
        public ManagerResponse? CreateManager(ManagerRequest managerRequest)
        {
            var exists = managerRepository.IsExist(managerRequest.Email);
            if(exists) return null;
            {
                var manager = new Manager(managerRequest.Name, managerRequest.Email, 1, managerRequest.Email)
            {
                Name = managerRequest.Name,
                Email = managerRequest.Email
            };

            managerRepository.AddToDb(manager);
            return new ManagerResponse(manager.Id, manager.Name);
            }
            
        }

    }
}
