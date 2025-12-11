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
        public void Add(Delivery delivery)
        {
            using (var connection = foodContext.CreateConnection())
            {
                var qry = @"Queries\Delivery\addDelivery.sql";
                var command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue(@"Name", delivery.Name);
                command.Parameters.AddWithValue(@"Email", delivery.Email);
                command.Parameters.AddWithValue(@"PlateNumber", delivery.PlateNumber);
                command.Parameters.AddWithValue(@"IsAvailable", delivery.IsAvailable);
                command.Parameters.AddWithValue(@"CreatedBy", delivery.CreatedBy);
                command.Parameters.AddWithValue(@"DateCreated", delivery.DateCreated);
                
                command.ExecuteNonQuery();

            }
        }

        public Delivery? Get(string email)
        {
             using (var connection = foodContext.CreateConnection())
            {
                var qry = @"Queries\Delivery\getByEmail.sql";
                var command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue(@"Email", email);
               var reader = command.ExecuteReader();


                if (reader.Read())
                {
                    return new Delivery
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        PlateNumber = reader.GetString(3),
                        IsAvailable = reader.GetBoolean(4),
                        CreatedBy = reader.GetString(5),
                        DateCreated = reader.GetDateTime(6)
                    };
                }
            }  
            return null;
        }

        public List<Delivery> GetAll()
        {
            using (var connection = foodContext.CreateConnection())
            {
                List<Delivery> deliveries = [];
                var qry = @"Queries\Delivery\getAll.sql";
                var command = new MySqlCommand(qry, connection);

                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    var delivery =  new Delivery
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        PlateNumber = reader.GetString(3),
                        IsAvailable = reader.GetBoolean(4),
                        CreatedBy = reader.GetString(5),
                        DateCreated = reader.GetDateTime(6)
                    };
                    deliveries.Add(delivery);
                }
                return deliveries;
            }
    
        }
    }
}