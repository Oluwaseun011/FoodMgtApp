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
        public string Description{get;set;} = null!;
        public decimal Price{get; set;} 
        public int CategoryId{get;set;}
        public int Quantity{get;set;}

        public Food(string name, string description,decimal price,int categoryId,int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
            Quantity = quantity;
        }

    }
}