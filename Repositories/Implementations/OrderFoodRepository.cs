using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodDeliveryApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodDeliveryApp.Repositories.Implementations
{
    public class OrderFoodRepository : IOrderFoodRepository
    {
        FoodContext foodContext = new FoodContext();
        public void Add(OrderFood orderFood)
        {
            using (var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\Category\Add.sql");
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue(@"OrderId", orderFood.OrderId);
                command.Parameters.AddWithValue(@"FoodId", orderFood.FoodId);
                command.ExecuteNonQuery();
            }
        }

        public ICollection<OrderFood> Get(int orderId)
        {
            using (var connection = foodContext.CreateConnection())
            {
                ICollection<OrderFood> orderFoods = new HashSet<OrderFood>();
                var query = File.ReadAllText(@"Queries\OrderFood\Get.sql");
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var orderFood = new OrderFood()
                    {
                        Id = reader.GetInt32(0),
                        OrderId = reader.GetInt32(1),
                        FoodId = reader.GetInt32(2)
                    };
                    orderFoods.Add(orderFood);
                }
                return orderFoods;
            }
        }
    }
}