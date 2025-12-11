using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Enums;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class BranchRepository : IBranchRepository
    {
        
        FoodContext foodContext = new FoodContext();
        public void Add(Branch branch)
        {
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\branch\addBranch.sql");
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@KitchenId", branch.KitchenId);
                command.Parameters.AddWithValue("@RefNumber", branch.RefNumber);
                command.Parameters.AddWithValue("@Email", branch.Email);
                command.Parameters.AddWithValue("@PhoneNumber", branch.PhoneNumber);
                command.Parameters.AddWithValue("@State", branch.State);
                command.Parameters.AddWithValue("@IsDeleted", branch.IsDeleted);
                command.Parameters.AddWithValue("@CreatedBy", branch.CreatedBy);
                command.Parameters.AddWithValue("@DateCreated", branch.DateCreated);

                command.ExecuteNonQuery();
            }
        }

        public Branch? GetBranch(int kitchenId, State state)
        {
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\branch\getBranch.sql");
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@KitchenId",kitchenId);
                command.Parameters.AddWithValue("@State",state);

                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    var branch = new Branch()
                    {
                        KitchenId = reader.GetInt32(0),
                        State = (State)reader.GetInt32(1)
                    };
                    return branch;
                }
                return null;
            }
        }

        public ICollection<Branch> GetSelected(int kitchenId)
        {
            ICollection<Branch> branches = new List<Branch>();
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\branch\getSelected.sql");
                var command = new MySqlCommand(query, connection);

                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    var branch = new Branch()
                    {
                        KitchenId = reader.GetInt32(0),
                        RefNumber = reader.GetString(1),
                        Email = reader.GetString(2),
                        PhoneNumber = reader.GetString(3),
                        State = (State)reader.GetInt32(4),
                        IsDeleted = reader.GetBoolean(5),
                        CreatedBy = reader.GetString(6),
                        DateCreated = reader.GetDateTime(7)
                    };
                    branches.Add(branch);
                }
                return branches;
            }
        }

        public bool IsExist(int kitchenId, State state)
        {
            using(var connection = foodContext.CreateConnection())
            {
                var query = File.ReadAllText(@"Queries\CreateTables\branch\isbranchExist.sql");
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@KitchenId",kitchenId);
                command.Parameters.AddWithValue("@State",state);

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