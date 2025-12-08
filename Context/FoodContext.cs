using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FoodDeliveryApp.Context
{
    public class FoodContext
    {
        public const string ConnectionString = "server=localhost;user=root;password=Pa$$word";
        public const string ConnectionString2 = "server=localhost;user=root;password=Pa$$word;database=FoodMgtApp";

    
        public void Run()
        {
            CreateSchema();
            CreateTable(Queries.kitchens);
            CreateTable(Queries.managers);
            CreateTable(Queries.branches);
            CreateTable(Queries.supervisors);
            CreateTable(Queries.categories);
            CreateTable(Queries.foods);
            CreateTable(Queries.deliveries);
            CreateTable(Queries.customers);
            CreateTable(Queries.wallets);
            CreateTable(Queries.orders);
            CreateTable(Queries.users);
            CreateTable(Queries.roles);
            CreateTable(Queries.userroles);
        }
        public MySqlConnection CreateConnection()
        {
            using(var connection = new MySqlConnection(ConnectionString2))
            {
                connection.Open();
                return connection;
            }
        }
        private void CreateSchema()
        {
            using(var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                var qry = Queries.schema;
                
                using(var command = new MySqlCommand(qry, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void CreateTable(string qry)
        {
            using(var connection = CreateConnection())
            {
                using(var command = new MySqlCommand(qry, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        
    }
}