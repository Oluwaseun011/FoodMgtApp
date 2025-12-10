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
        FoodContext context = new FoodContext();
        public void AddToDb(Role role)
        {
            using(var connection = context.CreateConnection())
            {
                var query = "insert into roless(Name,IsDeleted,UserRoles) values(@Name,@IsDeleted,@UserRoles)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", role.Name);
                command.Parameters.AddWithValue("@IsDeleted", role.IsDeleted);
                command.Parameters.AddWithValue("@UserRoles", role.UserRoles);

                command.ExecuteNonQuery();
            }
        }

        public Role? GetRole(int id)
        {
            using (var connection = context.CreateConnection())
            {
                var qry = "select * from roles where Id = @Id";
                using (var command = new MySqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        var user = new Role
                        {
                           Name = reader.GetString(0),
                           IsDeleted = reader.GetBoolean(1)
                        
                        };
                        return user;
                    }
                    return null;
                }
                
            }
        }

        public ICollection<Role> GetRoles()
        {
             ICollection<Role> roles = new List<Role>();
            using (var connection = context.CreateConnection())
            {
                var qry = "select * from roles";
                using (var command = new MySqlCommand(qry, connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var role = new Role
                        {
                            Name = reader.GetString(0),
                            IsDeleted = reader.GetBoolean(1)
                        };
                        roles.Add(role);
                    }
                    return roles;
                }
            }
        }

        public bool IsExist(string name)
        {
            using(var connection = context.CreateConnection())
            {
                var qry = "select * from roles where Name = @Name";

                using(var command = new MySqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);

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