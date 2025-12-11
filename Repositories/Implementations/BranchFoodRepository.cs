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
    public class BranchFoodRepository : IBranchFoodRepository
    {
        FoodContext foodContext = new FoodContext();
        public void Add(BranchFood branchFood)
        {
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\branchFood\addBranchFood.sql");
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@BranchId", branchFood.BranchId);
                command.Parameters.AddWithValue("@FoodId", branchFood.FoodId);
                command.Parameters.AddWithValue("@Price", branchFood.Price);
                command.Parameters.AddWithValue("@Quantity", branchFood.Quantity);

                command.ExecuteNonQuery();
            }
        }

        public ICollection<BranchFood> Get(int foodId)
        {
            ICollection<BranchFood> branchFoods = new List<BranchFood>();
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\branchFood\addBranchFood.sql");
                var command = new MySqlCommand(query, connection);

                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    var branchFood = new BranchFood()
                    {
                        BranchId = reader.GetInt32(0),
                        FoodId = reader.GetInt32(1),
                        Price = reader.GetDecimal(2),
                        Quantity = reader.GetInt32(3)
                    };
                    branchFoods.Add(branchFood);
                }
                return branchFoods;
            }
        }
    }
}