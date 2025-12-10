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
        public string RefNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public State State {get;set;}
        public bool IsDeleted {get;set;}
        public string CreatedBy {get;set;} = default!;
        public DateTime DateCreated {get;set;} = DateTime.UtcNow;
        
    }
}