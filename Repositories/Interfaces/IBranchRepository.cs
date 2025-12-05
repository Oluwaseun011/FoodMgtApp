using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IBranchRepository
    {
        void Add(Branch branch);
        bool IsExist(string branchName);
        Branch? GetBranch(int id);
        List<Branch> GetAllBranches();
    }
}