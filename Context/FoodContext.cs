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

        public MySqlConnection CreateSchema()
        {
            using(var connection = new MySqlConnection(ConnectionString2))
            {
                connection.Open();
                return connection;
            }
        }

        public MySqlConnection CreateConnectionString()
        {
            using(var con = new mysqlconn)
        }
    }
}