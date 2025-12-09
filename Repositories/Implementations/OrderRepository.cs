using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        FoodContext foodContext = new FoodContext();
        public void AddOrder(Order order)
        {
            using (var connection = foodContext.CreateConnection())
            {
                string qry = "insert into orders(RefNumber, CustomerId, Status, DeliveryId, Products, DateCreated, CreatedBy, IsDeleted) values (@RefName, @CustomerId, @Status, @DeliveryId, @Products, @DateCreated, @CreatedBy, @IsDeleted)";

                using (var command = new MySqlCommand(qry,connection))
                {
                    command.Parameters.AddWithValue("@RefNumber", order.RefNumber);
                    command.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                    command.Parameters.AddWithValue("@Status", order.Status);
                    command.Parameters.AddWithValue("@DeliveryId", order.DeliveryId);
                    command.Parameters.AddWithValue("@Products", order.Products);
                    command.Parameters.AddWithValue("@DateCreated", order.DateCreated);
                    command.Parameters.AddWithValue("@CreatedBy", order.RefNumber);
                    command.Parameters.AddWithValue("@IsDeleted", order.IsDeleted);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            using (var connection = foodContext.CreateConnection())
            {
                string qry = "select * from orders";
                using (var command = new MySqlCommand(qry,connection))
                {
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var order = new Order(reader.GetInt32(0),reader.GetString(1),reader.GetInt32(2),reader.GetInt32(3),reader.GetInt32(4),reader)
                    }
                }
            }
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