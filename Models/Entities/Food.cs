using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Food
    {
        public int Id { get; set;}
        public string Name{get;set;} = null!;
        public int CategoryId{get;set;}
        public Category Category{get; set;} = default!;
        public ICollection<OrderFood> OrderFoods {get; set;} = new HashSet<OrderFood>(); 

    }
}