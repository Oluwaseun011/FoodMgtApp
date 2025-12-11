using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Enums;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IBranchRepository
    {
        bool IsExist(int kitchenId, State state);
        void Add(Branch branch);
        Branch? GetBranch(int kitchenId, State state);
        ICollection<Branch> GetSelected(int kitchenId);
    }
}