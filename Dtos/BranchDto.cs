using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Entities;
using FoodMgtApp.Models.Enums;

namespace FoodMgtApp.Dtos
{
    public class BranchDto
    {
        public int Id {get;set;}
        public int KitchenId {get;set;}
        public Kitchen Kitchen{get; set;} = default!;
        public string Name {get;set;} = default!;
        public State State {get;set;}
        public bool IsDeleted {get;set;}
        public string CreatedBy {get;set;} = default!;
        public DateTime DateCreated {get;set;}
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public List<UserRole> UserRoles {get; set;} = new List<UserRole>();
        public int BranchId {get;set;}
        public string StaffNo {get;set;}= default!;

    }
    public record RegisterBranchRequest(int KitchenId,string Name,State State,string Email,string Password);
    public record RegisterBranchResponse(int Id, string Name);
}