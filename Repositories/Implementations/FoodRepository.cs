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
        FoodContext foodContext = new FoodContext();
        public void Add(Food food)
        {
            using (MySqlConnection sqlConnection =  foodContext.CreateConnection())
            {
                var query = "insert into foods(Name,Discription,Price,Quantity,CategoryId) values (@Name,@Description,@Price,@Quantity,@CategoryId)";
                var mySqlCommand = new MySqlCommand(query,sqlConnection);
                mySqlCommand.Parameters.AddWithValue("@Name",food.Name);
                mySqlCommand.Parameters.AddWithValue("@Description",food.Description);
                mySqlCommand.Parameters.AddWithValue("@Price",food.Price);
                mySqlCommand.Parameters.AddWithValue("@CategoryId",food.CategoryId);
                mySqlCommand.Parameters.AddWithValue("@Quantity",food.Quantity);

                mySqlCommand.ExecuteNonQuery();
            }
        }

        public ICollection<Food> GetAllFood()
        {
             using(MySqlConnection mySqlConnection = foodContext.CreateConnection())
            {
                
                var query = "select * from foods where Id is @Id";
                ICollection<Food> foods = [];
                var mySqlCommand = new MySqlCommand(query,mySqlConnection);
                var reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Food food = new Food(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetDecimal(2),
                        reader.GetInt32(3),
                        reader.GetInt32(4)
                    );
                    foods.Add(food);
                }
                return foods;
            }    
        }

        public Food? GetFood(int id)
        {
            using(MySqlConnection mySqlConnection = foodContext.CreateConnection())
            {
                var query = "select * from foods where Id is @Id";
                var mySqlCommand = new MySqlCommand(query,mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@Id",id);
                var reader = mySqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    Food food = new Food(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetDecimal(2),
                        reader.GetInt32(3),
                        reader.GetInt32(4)
                    );
                    return food;
                }
                return null;
            }
        }

        public bool IsExist(string name)
        {
            using(MySqlConnection mySqlConnection = foodContext.CreateConnection())
            {
                var query = "select * from foods where Name is @Name";
                var mySqlCommand = new MySqlCommand(query,mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@Name",name);
                var reader = mySqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    // Food food = new Food(
                    //     reader.GetString(0),
                    //     reader.GetString(1),
                    //     reader.GetDecimal(2),
                    //     reader.GetInt32(3),
                    //     reader.GetInt32(4)
                    // );
                    return true;
                }
                return false;
            }
        }
    }
}