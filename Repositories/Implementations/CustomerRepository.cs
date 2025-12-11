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
           using (var connection = foodContext.CreateConnection())
            {
                var qry = @"Queries\Customer\addCustomer.sql";
                var command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue(@"Name", customer.Name);
                command.Parameters.AddWithValue(@"Email", customer.Email);
                command.Parameters.AddWithValue(@"Address", customer.Address);

                command.ExecuteNonQuery();

            }
        }

        public Customer? Get(int id)
        {
            using (var connection = foodContext.CreateConnection())
            {
                var qry = @"Queries\Customer\getById.sql";
                var command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue(@"Id", id);
               var reader = command.ExecuteReader();


                if (reader.Read())
                {
                    return new Customer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Address = (State) reader.GetInt32(3)
                    };
                }
            }  
            return null;
        }

        public Customer? Get(string email)
        {
            using (var connection = foodContext.CreateConnection())
            {
                var qry = @"Queries\Customer\getByEmail.sql";
                var command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue(@"Email", email);
               var reader = command.ExecuteReader();


                if (reader.Read())
                {
                    return new Customer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Address = (State) reader.GetInt32(3)
                    };
                }
            }  
            return null;
        }

        public List<Customer> GetAll()
        {
            using (var connection = foodContext.CreateConnection())
            {
                List<Customer> customers = new List<Customer>();
                var qry = @"Queries\Guardian\getAll.sql";
                var command = new MySqlCommand(qry, connection);

                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    var customer =  new Customer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Address = (State) reader.GetInt32(3)
                    };
                    customers.Add(customer);
                }
                return customers;
            }
    
        }
    }
}