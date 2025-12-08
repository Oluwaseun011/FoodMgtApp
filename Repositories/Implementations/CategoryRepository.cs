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
    public class CategoryRepository : ICategoryRepository
    {
        FoodContext foodcontext = new FoodContext();
        public void Add(Category category)
        {
            using (var connection = foodcontext.CreateConnectionString())
            {
                var quary = "insert into categories (KitchenId,Name,Food) values (@Name,@KitchenId,@Food)";
                var command = new MySqlCommand(quary, connection);
                command.Parameters.AddWithValue("@Name", category.Name);
                command.Parameters.AddWithValue("@KitchenId", category.KitchenId);
                command.Parameters.AddWithValue("@Food", category.Foods);

                command.ExecuteNonQuery();
            }
        }

        public ICollection<Category> GetAllCategories()
        {
           ICollection <Category> categories = new List<Category>();
           using (var connection = foodcontext.CreateConnectionString())
            {
                string qry = "select * from categories";
                using(var command = new MySqlCommand(qry, connection))
                {
                    var reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        var category = new Category(reader.GetInt32(1),reader.GetString(2));
                        categories.Add(category);
                    }
                    return categories;
                }

            }
        }
        public Category? GetCategory(int id)
        {
            using (var connection = foodcontext.CreateConnectionString())
            {
                var quary = "select * from categories where Id = @Id";
                var command = new MySqlCommand(quary, connection);
                command.Parameters.AddWithValue("@Id", id);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var category = new Category(
                        reader.GetInt32(1),
                        reader.GetString(2)
                    );
                    return category;
                }
                return null;
            }
        }

        public ICollection<Category> GetKitchenCategories()
        {
            ICollection <Category> categories = new List <Category>();
            using (var connection = foodcontext.CreateConnectionString())
            {
                var quary = "select * from categories";
                using(var command = new MySqlCommand(quary, connection))
                {
                    var reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        var category = new Category(reader.GetInt32(1),reader.GetString(2));
                        categories.Add(category);
                    }
                    return categories;
                }
            }
        }

        public bool IsExist(string categoryName)
        {
           
        }
    }
}