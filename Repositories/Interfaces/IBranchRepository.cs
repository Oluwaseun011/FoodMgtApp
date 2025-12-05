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
        void Add(Branch branch);
        bool IsExist(string branchName);
        Branch? GetBranch(int kitchenId, State state);
        ICollection<Branch> GetKitchenBranch(int kitchenId);
        ICollection<Branch> GetLocationBranches(State state);
    }
}