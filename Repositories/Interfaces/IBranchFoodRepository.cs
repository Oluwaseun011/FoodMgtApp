using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodDeliveryApp.Repositories.Interfaces
{
    public interface IBranchFoodRepository
    {
        void Add(BranchFood branchFood);
        ICollection<BranchFood> Get(int foodId);
    }
}