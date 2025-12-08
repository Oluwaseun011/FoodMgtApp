using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Enums;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class BranchRepository : IBranchRepository
    {
        FoodContext context = new FoodContext();
        public void Add(Branch branch)
        {
            using (var connection = context.CreateConnection())
            {
                var quary = "insert into branch(KitchenId,State,IsDeleted,CraetedBy,DateCreated) values(@kitchenId,@kitchen,@state,@isDeleted,@createdBy,@dateCreated)";

                var command = new MySqlCommand(quary, connection);
                command.Parameters.AddWithValue("@kitchenId", branch.Id);
                command.Parameters.AddWithValue("@state", branch.State);
                command.Parameters.AddWithValue("@isdeleted", branch.IsDeleted);
                command.Parameters.AddWithValue("@createdBy", branch.CreatedBy);
                command.Parameters.AddWithValue("@dateCreated", branch.DateCreated);

                command.ExecuteNonQuery();
            }
        }

        public Branch? GetBranch(int kitchenId, State state)
        {
            using (var connection = context.CreateConnection())
            {
                var query = "select * from branch where KitchenId = @kitchenId,State = @state";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@kitchenid", kitchenId);
                command.Parameters.AddWithValue("@state", state);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var branch = new Branch(
                    reader.GetInt32(0),
                    (State)reader.GetInt32(1),
                    reader.GetString(2)
                    );
                    return branch;
                }
                return null;
            }
        }

        public ICollection<Branch> GetKitchenBranch(int kitchenId)
        {
            ICollection<Branch> branches = new List<Branch>();
            using (var connection = context.CreateConnection())
            {
                var query = "select * from branch where KitchenId = @kitchenId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@kitchenid", kitchenId);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var branch = new Branch(reader.GetInt32(1), (State)reader.GetInt32(2), reader.GetString(3));
                    branches.Add(branch);
                }
                return branches;
            }

        }

        public ICollection<Branch> GetLocationBranches(State state)
        {
            ICollection<Branch> branches = new List<Branch>();
            using (var connection = context.CreateConnection())
            {
                var query = "select * from branch where state = @state";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@state", state);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var branch = new Branch(reader.GetInt32(1), (State)reader.GetInt32(2), reader.GetString(3));
                    branches.Add(branch);
                }
                return branches;
            }
        }



    }
}