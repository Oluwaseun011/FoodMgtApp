using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Food> Foods { get; set; } = null!;

        public Category(string name, List<Food> food)
        {
            Name = name;
            Foods = food;
        }
        
    }
}