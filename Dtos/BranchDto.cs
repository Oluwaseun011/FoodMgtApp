using FoodDeliveryApp.Models.Entities;
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
    }
    public record RegisterBranchRequest(string Name,State State,Kitchen Kitchen);
    public record RegisterBranchResponse(string Name,State State);
}