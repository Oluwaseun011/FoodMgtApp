using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp;
using MySql.Data.MySqlClient;

namespace FoodDeliveryApp.Context
{
    public class FoodContext
    {    
        public void Run()
        {
            CreateSchema();
            CreateTable(File.ReadAllText(@"Queries\branchTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\categoryTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\customerTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\deliveryTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\foodTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\kitchenTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\orderFoodTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\orderTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\roleTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\userRoleTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\userTable.sql"));
            CreateTable(File.ReadAllText(@"Queries\walletTable.sql"));
            
        }
        public MySqlConnection CreateConnection()
        {
            using(MySqlConnection connection = new(AppSettings.ConnectionString2))
            {
                connection.Open();
                return connection;
            }
        }
        
        private void CreateSchema()
        {
            using(var connection = new MySqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();
                var qry = File.ReadAllText(@"Queries\schema.sql");
                var command = new MySqlCommand(qry, connection);
                command.ExecuteNonQuery();
            }
        }

        private void CreateTable(string qry)
        {
            using(var connection = CreateConnection())
            {
                var command = new MySqlCommand(qry, connection);
                command.ExecuteNonQuery();
            }
        }

        
    }
}