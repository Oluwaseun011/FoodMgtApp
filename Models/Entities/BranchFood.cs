using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class BranchFood
    {
        public int Id{get; set;}
        public int BranchId{get; set;}
        public Branch Branch{get; set;} = default!;
        public int FoodId{get; set;}
        public Food Food{get; set;} = default!;
        public decimal Price{get; set;} 
        public int Quantity{get;set;}
    }
}