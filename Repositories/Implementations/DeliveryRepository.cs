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
    public class DeliveryRepository : IDeliveryRepository
    {
        FoodContext foodContext = new FoodContext();
        public void AddDelivery(Delivery delivery)
        {
            using (var connection = foodContext.CreateConnection())
            {
                string qry = "insert into deliveries(Name, PlateNumber, IsAvailable, CreatedBy, DateCreated, IsDeleted) values (@Name, @PlateNumber, @IsAvailable, @CreatedBy, @DateCreated, @IsDeleted)";

                var command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue("@Name", delivery.Name);
                command.Parameters.AddWithValue("@PlateNumber", delivery.PlateNumber);
                command.Parameters.AddWithValue("@IsAvailable", delivery.IsAvailable);
                command.Parameters.AddWithValue("@CreatedBy", delivery.CreatedBy);
                command.Parameters.AddWithValue("@DateCreated", delivery.DateCreated);
                command.Parameters.AddWithValue("@IsDeleted", delivery.IsDeleted);

                command.ExecuteNonQuery();
            }
        }

        public List<Delivery> GetAllDeliveries()
        {
            List<Delivery> deliveries = new List<Delivery>();

            using (var connection = foodContext.CreateConnection())
            {
                string qry = "select * from deliveries";

                using (var command = new MySqlCommand(qry, connection))
                {
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var delivery = new Delivery(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetBoolean(5), reader.GetDateTime(6));

                        deliveries.Add(delivery);
                    }
                    return deliveries;
                }
            }
        }

        public List<Delivery> GetAvailableDeliveryGuy()
        {
            List<Delivery> deliveries = new List<Delivery>();

            using (var connection = foodContext.CreateConnection())
            {
                string qry = "select * from deliveries where IsAvailable = 0";

                using (var command = new MySqlCommand(qry, connection))
                {
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var delivery = new Delivery(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetBoolean(5), reader.GetDateTime(6));

                        deliveries.Add(delivery);
                    }
                    return deliveries;
                }
            }
        }

        public Delivery? GetDeliveryByEmail(string email)
        {
            using (var connection = foodContext.CreateConnection())
            {
                string qry = $"select * from deliveries where email = {email}";

                using (var command = new MySqlCommand(qry, connection))
                {
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Delivery(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetBoolean(5), reader.GetDateTime(6));
                    }
                    return null;
                }
            }
        }

        public bool IsDeliveryGuyAvailable(int deliveryId)
        {
            using (var connection = foodContext.CreateConnection())
            {
                string qry = $"select * from deliveries where deliveryid = @deliveryId";

                using (var command = new MySqlCommand(qry,connection))
                {
                    command.Parameters.AddWithValue("@deliveryId",deliveryId);

                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}