using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Dtos;
using FoodMgtApp.Models.Enums;
using FoodMgtApp.Repositories.Implementations;
using FoodMgtApp.Repositories.Interfaces;
using FoodMgtApp.Services.Interfaces;

namespace FoodMgtApp.Services.Implementations
{
    public class BranchService : IBranchService
    {
        IBranchRepository branchRepository = new BranchRepository();
        ISupervisorRepository supervisorRepository = new SupervisorRepository();
        public RegisterBranchResponse? Create(RegisterBranchRequest registerBranchRequest)
        {
            var exist = branchRepository.GetBranch(registerBranchRequest.KitchenId,registerBranchRequest.State);
            if(exist is null) return null;

            var branch = new Branch(registerBranchRequest.KitchenId,registerBranchRequest.State,registerBranchRequest.Email);
           
            var supervisor = new Supervisor(registerBranchRequest.BranchId,registerBranchRequest.Name,registerBranchRequest.StaffNo,registerBranchRequest.Email,registerBranchRequest.CreatedBy);
            

            branchRepository.Add(branch);
            supervisorRepository.Add(supervisor);
        

            return new RegisterBranchResponse(branch.Id,supervisor.Name);
        
        }

    }
}