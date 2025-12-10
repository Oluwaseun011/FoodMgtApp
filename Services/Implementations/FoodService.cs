using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Dtos;
using FoodMgtApp.Repositories.Implementations;
using FoodMgtApp.Repositories.Interfaces;
using FoodMgtApp.Services.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Services.Implementations
{
    public class FoodService : IFoodService
    {
        IFoodRepository foodRepository = new FoodRepository();
        public RegisterFoodResponse? CreateFood(RegisterFoodRequest food)
        {
           var foods = new RegisterFoodResponse(food.CategoryId,food.Name);
            if (foodRepository.IsExist(foods.Name)  == false)
            {
                Food food1 = new Food(food.Name,food.Description,food.Price,food.CategoryId,food.Quantity);
                foodRepository.Add(food1);
                return foods;
            }
            return null;
        }
        FoodContext foodContext = new FoodContext();
        public bool DeleteProduct(int id)
        {
            
            using (var con = foodContext.CreateConnection())
            {
                // var q = "select * from foods where Id = @Id";
               
                var query = "delete * from foods where Id = @Id";
                var q = "select * from foods where Id = @Id";
                var command = new MySqlCommand(query,con);
                command.Parameters.AddWithValue("@Id",id);
                var com = new MySqlCommand(q,con);
                var r =  com.ExecuteReader();
                if (r.Read())
                {
                    command.ExecuteNonQuery();
                    return true;
                }              
                return false; 
            }
        }

        public List<Food> GetAllFoods()
        {
            List<Food> foods = [];
            foreach(var item in foodRepository.GetAllFood())
            {
                foods.Add(item);
            }
            return foods;
        }

        public Food? GetFoodById(int Id)
        {
            return foodRepository.GetFood(Id);
        }
    }
}