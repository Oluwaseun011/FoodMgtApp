using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;

namespace FoodMgtApp.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Order? GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}