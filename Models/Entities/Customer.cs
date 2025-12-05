using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Customer
    {
        public int Id {get; set;}
        public string Name {get; set;} = default!;
        public string Email {get; set;} = default!;
        public string Address {get; set;} = default!;

        public Customer(string name, string email,string address)
        {
            Name = name;
            Email = email;
            Address = address;
            
        }
        
    }
}