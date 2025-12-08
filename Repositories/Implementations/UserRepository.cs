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
    public class UserRepository : IUserRepository
    {
        FoodContext context = new FoodContext();
        public void AddToDb(User user)
        {
            using(var connection = context.CreateConnectionString())
            {
                var query = "insert into users(Email,Password,CreatedBy,IsDeleted,DateCreated) values(@Email,@Password,@CreatedBy,@IsDeleted,@DateCreated)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@CreatedBy", user.CreatedBy);
                command.Parameters.AddWithValue("@IsDeleted", user.IsDeleted);
                command.Parameters.AddWithValue("@DateCreated", user.DateCreated);

                command.ExecuteNonQuery();
            }
        }

        public User? GetUser(string email)
        {
            using (resource)
            {
                
            }
        }

        public ICollection<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string email)
        {
            throw new NotImplementedException();
        }
    }
}