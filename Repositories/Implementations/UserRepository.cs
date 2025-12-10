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
        FoodContext context = new FoodContext();
        public void AddToDb(User user)
        {
            using(var connection = context.CreateConnection())
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
            using (var connection = context.CreateConnection())
            {
                var qry = "select * from users where Email = @Email";
                using (var command = new MySqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        var user = new User
                        {
                           Email = reader.GetString(0),
                           Password = reader.GetString(1),
                           CreatedBy = reader.GetString(2),
                           IsDeleted = reader.GetBoolean(3),
                           DateCreated = reader.GetDateTime(4) 
                        };
                        return user;
                    }
                    return null;
                }
                
            }
        }

        public ICollection<User> GetUsers()
        {
            ICollection<User> users = new List<User>();
            using (var connection = context.CreateConnection())
            {
                var qry = "select * from students";
                using (var command = new MySqlCommand(qry, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var user = new User
                        {
                            Email = reader.GetString(0),
                            Password = reader.GetString(1),
                            CreatedBy = reader.GetString(2),
                            IsDeleted = reader.GetBoolean(3),
                            DateCreated = reader.GetDateTime(4)
                        };
                        users.Add(user);
                    }
                    return users;
                }
            }
        }
                                
        public bool IsExist(string email)
        {
            using(var connection = context.CreateConnection())
            {
                var qry = "select * from users where Email = @Email";

                using(var command = new MySqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

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