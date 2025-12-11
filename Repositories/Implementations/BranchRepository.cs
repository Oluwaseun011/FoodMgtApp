using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Enums;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class BranchRepository : IBranchRepository
    {
        public void Add(Branch branch)
        {
            throw new NotImplementedException();
        }

        public Branch? GetBranch(int kitchenId, State state)
        {
            throw new NotImplementedException();
        }

        public ICollection<Branch> GetSelected(int kitchenId)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(int kitchenId, State state)
        {
            throw new NotImplementedException();
        }
    }
}