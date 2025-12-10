using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class OrderFood
    {
        public int Id{get; set;}
        public int OrderId{get; set;}
        public Order Order{get; set;} = default!;
        public int FoodId{get; set;}
        public Food Food{get; set;} = default!;
    }
}