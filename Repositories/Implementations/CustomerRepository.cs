using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Enums;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        FoodContext foodContext = new FoodContext();
        public void AddCustomer(Customer customer)
        {
            using(var con = foodContext.CreateConnection())
            {
               var query = "insert into customers(Name,Email,Address) values (@Name,@Email,@Address)";
               var command = new MySqlCommand(query, con); 
               command.Parameters.AddWithValue("@Name", customer.Name);
               command.Parameters.AddWithValue("@Email",customer.Email);
               command.Parameters.AddWithValue("@Address",customer.Address);

               command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using(var con = foodContext.CreateConnection())
            {
                var query = "select * from customers";
                var command = new MySqlCommand(query,con);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var customer = new Customer(reader.GetString(1), reader.GetString(2),(State)reader.GetInt32(3));
                    customers.Add(customer);
                }
                return customers;
            }
        }

        public Customer? GetCustomerByEmail(string email)
        {
            using(var con = foodContext.CreateConnection())
            {
                var query = "select * from customers where Email = @Email";
                var command = new MySqlCommand(query, con);
                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    var customer = new Customer(
                    reader.GetString(1),
                    reader.GetString(2),
                    (State)reader.GetInt32(3)
                    );
                    return customer;
                }
                return null;
            }
        }

        public Customer? GetCustomerById(int id)
        {
            using(var con = foodContext.CreateConnection())
            {
                var query = "select * from customers where Id = @Id";
                var command = new MySqlCommand(query, con);
                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    var customer = new Customer(
                        reader.GetString(1),
                        reader.GetString(2),
                        (State)reader.GetInt32(3)
                    );
                    return customer;
                }
                return null;
            }
        }
    }
}