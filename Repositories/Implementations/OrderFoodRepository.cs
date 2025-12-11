using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodDeliveryApp.Repositories.Interfaces;

namespace FoodDeliveryApp.Repositories.Implementations
{
    public class OrderFoodRepository : IOrderFoodRepository
    {
        public void Add(OrderFood orderFood)
        {
            throw new NotImplementedException();
        }

        public ICollection<OrderFood> Get(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}