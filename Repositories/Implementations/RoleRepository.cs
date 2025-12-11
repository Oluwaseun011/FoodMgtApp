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
    public class RoleRepository : IRoleRepository
    {
        FoodContext foodContext = new FoodContext();
        public void AddToDb(Role role)
        {
            using (MySqlConnection connection = foodContext.CreateConnection())
            {
                string q = File.ReadAllText(@"Queries\Role\addRole.sql");
                using (MySqlCommand command = new MySqlCommand(q,connection))
                {
                    command.Parameters.AddWithValue("@Name",role.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Role? GetRole(string name)
        {
            using (MySqlConnection connection = foodContext.CreateConnection())
            {
                string query = File.ReadAllText(@"Queries\Role\getRole.sql");
                using (MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@Name",name);
                    var r = command.ExecuteReader();
                    if (r.Read())
                    {
                        return new Role
                        {
                            Id = r.GetInt32(0),
                            Name = r.GetString(1)
                        };
                    }
                    return null;
                }
            }
        }

        public ICollection<Role> GetRoles()
        {
            ICollection<Role> roles = [];
            using (MySqlConnection connection = foodContext.CreateConnection())
            {
                string query = File.ReadAllText(@"Queries\Role\getRole.sql");
                using (MySqlCommand command = new MySqlCommand(query,connection))
                {
                    var r = command.ExecuteReader();
                    while (r.Read())
                    {
                        Role role = new Role
                        {
                            Id = r.GetInt32(0),
                            Name = r.GetString(1)
                        };
                        roles.Add(role);
                    }
                    return roles;
                }
            }
        }

        public bool IsExist(string name)
        {
            using (MySqlConnection connection = foodContext.CreateConnection())
            {
                string query = File.ReadAllText(@"Queries\Role\getRole.sql");
                using (MySqlCommand command = new MySqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@Name",name);
                    var r = command.ExecuteReader();
                    if (r.Read())
                    {
                        return true;
                    }    
                    return false;
                }
            }
        }
    }
}