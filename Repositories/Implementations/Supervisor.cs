using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class Supervisor : ISupervisorRepository
    {
        FoodContext context = new FoodContext();
        public void Add(FoodDeliveryApp.Models.Entities.Supervisor supervisor)
        {
          using(var connection = context.CreateConnection())
            {
                var query = "select * from supervisor where supervisor = @supervisor";
                var command = new MySqlCommand(query,connection);
                command.Parameters.AddWithValue("@supervisor",supervisor);
                 var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    var supervoisor = new Supervisor(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetBoolean(3),
                        reader.GetString(4),
                        reader.GetDateTime(5)
                    
                    );
                    return branch;
                }
                return null;
            }
            }
        }

        public ICollection<FoodDeliveryApp.Models.Entities.Supervisor> GetAllSupervisors()
        {
            throw new NotImplementedException();
        }

        public FoodDeliveryApp.Models.Entities.Supervisor? GetSupervisor(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<FoodDeliveryApp.Models.Entities.Supervisor> GetSupervisorsInAKitchen(Kitchen kitchen)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string email)
        {
            throw new NotImplementedException();
        }

    }
}