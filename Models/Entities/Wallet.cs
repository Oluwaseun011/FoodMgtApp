using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Wallet
    {
        public int Id {get; set;}
        public int CustomerId {get; set;}
        public Customer Customer {get; set;} = default!;
        public double Amount {get; set;}

        public Wallet(int customerId)
        {
            CustomerId = customerId;
            Amount = 0;
        }
    }
}