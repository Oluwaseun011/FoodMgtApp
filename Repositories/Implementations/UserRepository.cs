using System;
using System.Collections.Generic;
using System.Data;
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
        FoodContext foodContext = new FoodContext();
        public void AddToDb(User user)
        {
            using (var connection = foodContext.CreateConnection())
            {
                string qry = File.ReadAllText(@"Queries\User\addUser.sql");

                using (var command = new MySqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@CreatedBy", user.CreatedBy);

                    command.ExecuteNonQuery();
                }
            }
        }

        public User? GetUser(string email)
        {
            using (MySqlConnection connection = foodContext.CreateConnection())
            {
                string query = File.ReadAllText(@"Queries\User\getUser.sql");
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            Email = reader.GetString(1),
                            Password = reader.GetString(2),
                            CreatedBy = reader.GetString(3),
                            DateCreated = reader.GetDateTime(4),
                            IsDeleted = reader.GetBoolean(5),
                        };
                    }
                    return null;
                }
            }
        }

        public bool IsExist(string email)
        {
             using (MySqlConnection connection = foodContext.CreateConnection())
            {
                string query = File.ReadAllText(@"Queries\User\getUser.sql");
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}