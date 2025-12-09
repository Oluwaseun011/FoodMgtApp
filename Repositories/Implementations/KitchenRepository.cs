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
        public void AddToDb(Kitchen kitchen)
        {
            using (var connection = foodContext.CreateConnection())
            {
                var query = $"insert into kitchens(Name, Description, CreatedBy, DateCreated, IsDeleted, Manager, Branches) values (@Name, @Description, @CreatedBy, @DateCreated, @IsDeleted, @Manager, @Branches)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", kitchen.Name);
                command.Parameters.AddWithValue("@Description", kitchen.Description);
                command.Parameters.AddWithValue("@CreatedBy", kitchen.CreatedBy);
                command.Parameters.AddWithValue("@DateCreated", kitchen.DateCreated);
                command.Parameters.AddWithValue("@IsDeleted", kitchen.IsDeleted);
                command.Parameters.AddWithValue("@Manager", kitchen.Manager);
                command.Parameters.AddWithValue("@Branches", kitchen.Branches);
                command.ExecuteNonQuery();
            }
            
        }

        public Kitchen? GetKitchen(string name)
        {
            using (var connection = foodContext.CreateConnection())
            {
                var query = "select * from kitchens where name = @name";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        var kitchen = new Kitchen(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        return kitchen;
                    }
                    return null;
                }
            }
        }

        public ICollection<Kitchen> GetKitchens()
        {
            ICollection<Kitchen> kitchens = new List<Kitchen>();
            using(var connection = foodContext.CreateConnection())
            {
                var query = "select * from kitchens";
                using(var command = new MySqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        var kitchen = new Kitchen(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        kitchens.Add(kitchen);
                    }
                    return kitchens;
                }
            }
        }

        public bool IsExist(string name)
        {
            using(var connection = foodContext.CreateConnection())
            {
                var query = "select * from customers where Name = @name";

                using(var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);

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
}