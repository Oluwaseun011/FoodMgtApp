using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;

namespace FoodMgtApp.Repositories.Implementations
{
    public class KitchenRepository : IKitchenRepository
    {
        FoodContext foodContext = new FoodContext();
        public void Add(Kitchen kitchen)
        {
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\Kitchen\addKitchen.sql");
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", kitchen.Name);
                command.Parameters.AddWithValue("@RefNumber", kitchen.RefNumber);
                command.Parameters.AddWithValue("@Email", kitchen.Email);
                command.Parameters.AddWithValue("@PhoneNumber", kitchen.PhoneNumber);
                command.Parameters.AddWithValue("@IsDeleted", kitchen.IsDeleted);
                command.Parameters.AddWithValue("@CreatedBy", kitchen.CreatedBy);
                command.Parameters.AddWithValue("@DateCreated", kitchen.DateCreated);

                command.ExecuteNonQuery();
            }
        }

        public Kitchen? Get(string name)
        {
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\Kitchen\getKitchen.sql");
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);

                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    var kitchen = new Kitchen()
                    {
                        Name = reader.GetString(0)
                    };
                    return kitchen;
                }
                return null;
            }
        }

        public ICollection<Kitchen> GetAll()
        {
            ICollection<Kitchen> kitchens = new List<Kitchen>();
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\Kitchen\getAllKitchens.sql");
                var command = new MySqlCommand(query, connection);

                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    var kitchen = new Kitchen()
                    {
                        Name = reader.GetString(0),
                        RefNumber = reader.GetString(1),
                        Email = reader.GetString(2),
                        PhoneNumber = reader.GetString(3),
                        IsDeleted = reader.GetBoolean(4),
                        CreatedBy = reader.GetString(5),
                        DateCreated = reader.GetDateTime(6)
                    };
                    kitchens.Add(kitchen);
                }
                return kitchens;
            }
        }

        public bool IsExist(string name)
        {
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\Kitchen\isKitchenExist.sql");
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", name);

                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    return true;
                }
                return false;
            }
        }
    }
}