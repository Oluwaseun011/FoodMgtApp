using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class FoodRepository : IFoodRepository
    {
        FoodContext context = new FoodContext();
        public void Add(Food food)
        {
            using (var connection = context.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\Category\Add.sql");
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue(@"Name", food.Name);
                command.Parameters.AddWithValue(@"CategoryId", food.CategoryId);
                command.ExecuteNonQuery();
            }
        }

        public ICollection<Food> GetAllFood(int kitchenId)
        {
            using (var connection = context.CreateConnection())
            {
                ICollection<Food> foods = new HashSet<Food>();
                var query = File.ReadAllText(@"Queries\Food\GetAllFood.sql");
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var food = new Food()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        CategoryId = reader.GetInt32(2)
                    };
                    foods.Add(food);
                }
                return foods;
            }
        }

        public Food? GetFood(int id)
        {
            using (var connection = context.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\Food\GetFood.sql");
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    return new Food
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        CategoryId = reader.GetInt32(2)
                    };
                    
                }
                return null;
            }
        }

        public bool IsExist(int kitchenId, string name)
        {
            using(var connection = context.CreateConnection())
            {
                var qry = "select * from foods where KitchenId = @kitchenId and Name = @name";

                using(var command = new MySqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@kitchenId", kitchenId);
                    command.Parameters.AddWithValue(@"Name", name);
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