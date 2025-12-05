using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Models.Enums;

namespace FoodDeliveryApp.Models.Entities
{
    public class Customer
    {
        public int Id {get; set;}
        public string Name {get; set;} = default!;
        public string Email {get; set;} = default!;
        public State Address {get; set;} = default!;
        public Wallet Wallet {get; set;} = default!;

        public Customer(string name, string email,State address)
        {
            Name = name;
            Email = email;
            Address = address;
            
        }
        
    }
}