using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Enums;

namespace FoodMgtApp.Dtos
{
    public class CustomerDto
    {
        public int Id {get; set;}
        public int CustomerId {get; set;}
        public Customer Customer {get; set;} = default!;
        public double Amount {get; set;}
        public string Name {get; set;} = default!;
        public string Email {get; set;} = default!;
        public State Address {get; set;} = default!;
        public Wallet Wallet {get; set;} = default!;
        
    }

    public record CustomerRequest(string Name, string Email, double Amount, State Address);
    public record CustomerResponse(int Id, string Name, string Email, double Amount, State Address, Wallet Wallet);
}