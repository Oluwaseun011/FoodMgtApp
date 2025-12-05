using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int KitchenId { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Food> Foods { get; set; } = new HashSet<Food>();

        public Category(int kitchenId,string name)
        {
            KitchenId = kitchenId;
            Name = name;
        }
        
    }
}