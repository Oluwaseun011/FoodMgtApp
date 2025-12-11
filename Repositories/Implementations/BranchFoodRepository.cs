using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodDeliveryApp.Repositories.Interfaces;

namespace FoodDeliveryApp.Repositories.Implementations
{
    public class BranchFoodRepository : IBranchFoodRepository
    {
        public void Add(BranchFood branchFood)
        {
            throw new NotImplementedException();
        }

        public ICollection<BranchFood> Get(int foodId)
        {
            throw new NotImplementedException();
        }
    }
}