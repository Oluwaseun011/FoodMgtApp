using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        Customer? Get(int id);
        Customer? Get(string email);
        List<Customer> GetAll();
    }
}