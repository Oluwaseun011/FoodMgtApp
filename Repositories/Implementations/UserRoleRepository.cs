using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodDeliveryApp.Repositories.Interfaces;
using FoodMgtApp.Models.Entities;
using MySql.Data.MySqlClient;

namespace FoodDeliveryApp.Repositories.Implementations
{
    public class UserRoleRepository : IUserRoleRepository
    {
        FoodContext foodContext = new FoodContext();
        public void Add(UserRole userRole)
        {
            using (MySqlConnection connection = foodContext.CreateConnection())
            {
                string query = File.ReadAllText(@"Queries\UserRole\addUserRole.sql");
                using (MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@UserId",userRole.UserId);
                    command.Parameters.AddWithValue("@RoleId",userRole.RoleId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public ICollection<UserRole> Get(int userId)
        {
            ICollection<UserRole> userRoles = [];
            using (MySqlConnection connection = foodContext.CreateConnection())
            {
                string query = File.ReadAllText(@"Queries\UserRole\getuserRoles.sql");
                using (MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@UserId",userId);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UserRole userRole =new UserRole
                        {
                            Id = reader.GetInt32(0),
                            UserId = reader.GetInt32(1),
                            RoleId = reader.GetInt32(2)
                        };
                        userRoles.Add(userRole);
                    }
                }
                return userRoles;
            }    
        }
    }
}