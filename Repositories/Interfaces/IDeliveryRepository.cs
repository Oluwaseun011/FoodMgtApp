using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IDeliveryRepository
    {
        void AddDelivery(Delivery delivery);
        Delivery? GetDeliveryByEmail(string email);
        Delivery? GetAvailableDelivery();
        int NextDeliveryId();
        List<Delivery> GetAllDeliveries();
    }
}