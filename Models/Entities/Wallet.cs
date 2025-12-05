using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Wallet
    {
        public int Id {get; set;}
        public double Amount {get; set;} = 0;
        public int CustomerId {get; set;}

        public Wallet(double amount, int customerId)
        {
            Amount = amount;
            CustomerId = customerId;

        }
    }
}