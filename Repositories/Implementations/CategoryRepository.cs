using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Misc;

namespace FoodMgtApp.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        FoodContext context = new FoodContext();
        public void Add(Category category)
        {
            using (var connection = context.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\Category\Add.sql");
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue(@"KitchenId", category.KitchenId);
                command.Parameters.AddWithValue(@"Name", category.Name);
                command.ExecuteNonQuery();
            }
        }

        public Category? GetCategory(int kitchenId, string name)
        {
            using (var connection = context.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\Category\GetCategory.sql");
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    return new Category
                    {
                        Id = reader.GetInt32(0),
                        KitchenId = reader.GetInt32(1),
                        Name = reader.GetString(2),
                    };
                    
                }
                return null;
            }
        }

        public ICollection<Category> GetKitchenCategories(int kitchenId)
        {
            using (var connection = context.CreateConnection())
            {
                ICollection<Category> categories = new HashSet<Category>();
                var query = File.ReadAllText(@"Queries\Category\GetKitchenCategories.sql");
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var category = new Category()
                    {
                        Id = reader.GetInt32(0),
                        KitchenId = reader.GetInt32(1),
                        Name = reader.GetString(2)
                    };
                    categories.Add(category);
                }
                return categories;
            }
        }

        public bool IsExist(int kitchenId, string name)
        {
            using(var connection = context.CreateConnection())
            {
                var qry = "select * from categories where KitchenId = @kitchenId and Name = @name";

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