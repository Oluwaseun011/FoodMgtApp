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
    public class ManagerRepository : IManagerRepository
    {
        FoodContext context = new FoodContext();
        public void AddToDb(Manager manager)
        {
            using (var connection = context.CreateConnectionString())
            {
                var query = $"insert into managers(Name, Email, KitchenId, Kitchen, CreatedBy, DateCreated, IsDeleted) values (@Name, @Email, @KitchenId, @Kitchen, @CreatedBy, @DateCreated, @IsDeleted)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", manager.Name);
                command.Parameters.AddWithValue("@Email", manager.Email);
                command.Parameters.AddWithValue("@KitchenId", manager.KitchenId);
                command.Parameters.AddWithValue("@CreatedBy", manager.CreatedBy);
                command.Parameters.AddWithValue("@Name", manager.DateCreated);
                command.Parameters.AddWithValue("@Name", manager.IsDeleted);
                command.ExecuteNonQuery();
            }
        }

        public Manager? GetManager(string email)
        {
            using (var connection = context.CreateConnectionString())
            {
                var query = "select * from managers where email = @email";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", email);
                    var reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        var manager = new Manager(reader.GetString(1),reader.GetString(2),reader.GetInt32(3),reader.GetString(4));
                        return manager;
                    }
                    return null;
                }
            }
        }

        public ICollection<Manager> GetManagers()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string email)
        {
            using (var connection = new MySqlConnection(FoodContext.CreateConnection()))
            {
                var query = "select * from managers where name = @name";
                using (var command = new MySqlCommand(query, connection))
                {
                    var emailExist = 
                } 
        }
    }
}