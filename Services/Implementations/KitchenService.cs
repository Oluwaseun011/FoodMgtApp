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
    public class KitchenService : IKitchenService
    {
        IKitchenRepository kitchenRepository = new KitchenRepository();
        public ICollection<Kitchen> GetAllKitchens()
        {
            return kitchenRepository.GetKitchens();
        }

        public Kitchen? GetKitchen(string id)
        {
            return kitchenRepository.GetKitchen(id);
        }

        public KitchenResponse? RegisterKitchen(KitchenRequest request)
        {
            var exists = kitchenRepository.IsExist(request.Name);
            if (exists) return null;
            {
                var kitchen = new Kitchen(request.Name, request.Description, request.Email)
                {
                    Name = request.Name,
                    Description = request.Description,
                    CreatedBy = request.Email
                };
                kitchenRepository.AddToDb(kitchen);
                return new KitchenResponse(kitchen.Id, kitchen.Name, kitchen.Description);
            }
            
        }
    }
}