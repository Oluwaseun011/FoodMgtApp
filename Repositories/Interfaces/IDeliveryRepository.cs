using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IDeliveryRepository
    {
        void Add(Delivery delivery);
        Delivery? Get(string email);
        List<Delivery> GetAll();
    }
}