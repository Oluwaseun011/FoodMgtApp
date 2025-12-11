using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Enums;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        FoodContext context = new FoodContext();
        public void AddOrder(Order order)
        {
            
        {
            using (var connection = context.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\Order\AddOrder.sql");
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue(@"Refnumber", order.CustomerId);
                command.Parameters.AddWithValue(@"CustomerId", order.CustomerId);
                command.Parameters.AddWithValue(@"Status", order.Status);
                command.Parameters.AddWithValue(@"DeliveryId", order.DeliveryId);
                command.ExecuteNonQuery();
            }
        }
        }
        

        public ICollection<Order> GetAllOrders()
        {
            using (var connection = context.CreateConnection())
            {
                ICollection<Order> orders = new List<Order>();
                var query = File.ReadAllText(@"Queries\Order\GetAllOrders.sql");
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var order = new Order()
                    {
                        Id = reader.GetInt32(0),
                        RefNumber = reader.GetString(1),
                        CustomerId = reader.GetInt32(2),
                        Status = (Status)reader.GetInt32(3),
                        DeliveryId = reader.GetInt32(4)
                    };
                    orders.Add(order);
                }
                return orders;
            }
        }

        public Order? GetOrderById(int id)
        {
            using (var connection = context.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\Order\GetOrderById.sql");
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    return new Order
                    {
                        Id = reader.GetInt32(0),
                        RefNumber = reader.GetString(1),
                        CustomerId = reader.GetInt32(2),
                        Status = (Status)reader.GetInt32(3),
                        DeliveryId = reader.GetInt32(4)
                    };
                    
                }
                return null;
            }
        }

        public ICollection<Order> GetOrdersByCustomerId(int customerId)
        {
            using (var connection = context.CreateConnection())
            {
                ICollection<Order> orders = new HashSet<Order>();
                var query = File.ReadAllText(@"Queries\Order\GetOrderByCustomerId.sql");
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var order = new Order()
                    {
                        RefNumber = reader.GetString(1),
                        CustomerId = reader.GetInt32(2),
                        Status = (Status)reader.GetInt32(3),
                        DeliveryId = reader.GetInt32(4)
                    };
                    orders.Add(order);
                }
                return orders;
            } 
        }
    }
}