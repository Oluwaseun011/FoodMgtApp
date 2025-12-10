using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodDeliveryApp.Repositories.Implementations;
using FoodDeliveryApp.Repositories.Interfaces;
using FoodMgtApp.Dtos;
using FoodMgtApp.Repositories.Implementations;
using FoodMgtApp.Repositories.Interfaces;
using FoodMgtApp.Services.Interfaces;
using Org.BouncyCastle.Asn1.Ocsp;

namespace FoodMgtApp.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        IWalletRepository walletRepository = new WalletRepository();
        IUserRepository userRepository= new UserRepository();
        public CustomerResponse Register(CustomerRequest request)
        {
            var customer = new Customer(request.Name, request.Email, request.Address);
            customerRepository.AddCustomer(customer);
            
            var user = new User(request.Email, request.Password,request.Email);
            userRepository.AddToDb(user);

            var wallet = new Wallet(customer.Id);
            walletRepository.AddWallet(wallet);

            return new CustomerResponse(customer.Id, customer.Email);
        }
    }
}