using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Entities;
using FoodMgtApp.Models.Enums;

namespace FoodMgtApp.Dtos
{
    public class BranchDto
    {
        public int UserId {get; set;}
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public ICollection<UserRole> UserRoles {get; set;} = new HashSet<UserRole>();  

        public int Id {get;set;}
        public int KitchenId {get;set;}
        public Kitchen Kitchen{get; set;} = default!;
        public string RefNumber { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public State State {get;set;}
        public bool IsDeleted {get;set;}
        public string CreatedBy {get;set;} = default!;
        public DateTime DateCreated {get;set;}
    }
    public record RegisterBranchRequestModel(string Email,string Password,int KitchenId,string PhoneNumber,State State);
    public record RegisterBranchResponseModel(string Name);
}