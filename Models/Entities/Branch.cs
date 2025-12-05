using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Models.Enums;

namespace FoodDeliveryApp.Models.Entities
{
    public class Branch
    {
        public int Id {get;set;}
        public int KitchenId {get;set;}
        public string Name {get;set;} = null!;
        public State State {get;set;}
        public bool IsDeleted {get;set;} = false;
        public string CreatedBy {get;set;} = null!;
        public DateTime DateCreated {get;set;} = DateTime.Now;

       public Branch(int kitchenId,string Name,State state,string createdBy)
        {
            KitchenId = kitchenId;
            BranchName = Name;
            State = state;
            CreatedBy = createdBy;
        }
        
    }
}