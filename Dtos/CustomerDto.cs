using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Entities;
using FoodMgtApp.Models.Enums;

namespace FoodMgtApp.Dtos
{
    public class CustomerDto
    {
        public int UserId {get; set;}
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public ICollection<UserRole> UserRoles {get; set;} = new HashSet<UserRole>(); 

        public int Id {get; set;}
        public string Name {get; set;} = default!;
        public State Address {get; set;} = default!;
        public Wallet Wallet {get; set;} = default!;
        public ICollection<Order> Orders{get; set;} = new HashSet<Order>();  

        public int WalletId {get; set;}
        public int CustomerId {get; set;}
        public Customer Customer {get; set;} = default!;
        public double Amount {get; set;}
        
    }

    public record RegisterCustomerRequestModel(string Email, string Password, string Name, State Address);
    public record RegisterCustomerResponseModel(string Name);
}