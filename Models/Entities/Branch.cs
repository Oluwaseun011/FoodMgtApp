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
        public Kitchen Kitchen{get; set;} = default!;
        public string Name {get;set;} = default!;
        public State State {get;set;}
        public bool IsDeleted {get;set;}
        public string CreatedBy {get;set;} = default!;
        public DateTime DateCreated {get;set;}

       public Branch(int kitchenId,string name,State state,string createdBy)
        {
            KitchenId = kitchenId;
            Name = name;
            State = state;
            CreatedBy = createdBy;
            IsDeleted = false;
            DateCreated = DateTime.UtcNow;
        }
        
    }
}