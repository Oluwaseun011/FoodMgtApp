using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IDeliveryRepository
    {
        void AddDelivery(string name, string email, string plateNumber);
        Delivery? GetDeliveryByEmail(string email);
        Delivery? GetAvailableDelivery();
        List<Delivery> GetAllDeliveries();
    }
}