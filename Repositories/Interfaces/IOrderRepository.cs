using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        Order? GetOrderById(int id);
        List<Order> GetOrdersByCustomerId(int customerId);
        List<Order> GetAllOrders();
    }
}