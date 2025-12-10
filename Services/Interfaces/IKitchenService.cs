using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Dtos;

namespace FoodMgtApp.Services.Interfaces
{
    public interface IKitchenService
    {
        KitchenResponse? RegisterKitchen(KitchenRequest request);
        Kitchen? GetKitchen(string id);
        ICollection<Kitchen> GetAllKitchens();
    }
}