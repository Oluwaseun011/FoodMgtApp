using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class SupervisorRepository : ISupervisorRepository
    {
        FoodContext context = new FoodContext();
        public void Add(FoodDeliveryApp.Models.Entities.Supervisor supervisor)
        {
          using(var connection = context.CreateConnection())
            {
                var query = "insert into supervisor (BranchId,Name,Email,StaffNo,IsDeleted,CreatedBy,DateCreated) values (@branchId,@name,@staffno,@email,@isDeleted,@createdBy,@dateCreated)";
                var command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@branchid",supervisor.BranchId);
                command.Parameters.AddWithValue("@name",supervisor.Name);
                command.Parameters.AddWithValue("@email",supervisor.Email);
                command.Parameters.AddWithValue("@staffno",supervisor.StaffNo);
                command.Parameters.AddWithValue("@isdeleted", supervisor.IsDeleted);
                command.Parameters.AddWithValue("@createdBy", supervisor.CreatedBy);
                command.Parameters.AddWithValue("@dateCreated", supervisor.DateCreated);
                command.ExecuteNonQuery();
               
            }
        }

        public ICollection<Supervisor> GetAllSupervisors()
        {
            ICollection<Supervisor> supervisors = new List<Supervisor>();
            using (var connection = context.CreateConnection())
            {
                var query = "select * from supervisor";
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var supervisor = new Supervisor(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)
                    );
                    supervisors.Add(supervisor);
                }
                return supervisors;
            }

        }

        public FoodDeliveryApp.Models.Entities.Supervisor? GetSupervisor(int id)
        {
             
            using (var connection = context.CreateConnection())
            {
                var query = "select * from supervisor where Id = @id";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var supervisor = new Supervisor(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)

                    );
                    return supervisor;
                }
                return null;
            }
        }

        public ICollection<FoodDeliveryApp.Models.Entities.Supervisor> GetSupervisorsInAKitchen(Kitchen kitchen)
        {
            using (var connection = context.CreateConnection())
            {
                ICollection<Supervisor> supervisors = new List<Supervisor>();
                var query = "select * from supervisor where Kitchen = @kitchen";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@kitchen", kitchen);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var supervisor = new Supervisor(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)
                    );
                    supervisors.Add(supervisor);
                    
                }
               return supervisors;
            }
        }

        public bool IsExist(string email)
        {
             using(var connection = context.CreateConnection())
            {
                var qry = "select * from supervisor where Email = @email";

                using(var command = new MySqlCommand(qry, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    var reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        ICollection<FoodDeliveryApp.Models.Entities.Supervisor> ISupervisorRepository.GetAllSupervisors()
        {
            throw new NotImplementedException();
        }
    }
}