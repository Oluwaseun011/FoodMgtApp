using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodDeliveryApp.Repositories.Interfaces
{
    public interface IOrderFoodRepository
    {
        void Add(OrderFood orderFood);
        ICollection<OrderFood> Get(int orderId);
    }
}