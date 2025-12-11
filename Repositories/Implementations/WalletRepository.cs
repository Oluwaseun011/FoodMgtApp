using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace FoodMgtApp.Repositories.Implementations
{
    public class WalletRepository : IWalletRepository
    {
        FoodContext foodContext = new FoodContext();
        public void AddWallet(Wallet wallet)
        {
            using (var connection = foodContext.CreateConnection())
            {
                var qry = @"Queries\Wallet\addWallet.sql";
                var command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue(@"CustomerId", wallet.CustomerId);
                command.Parameters.AddWithValue(@"Amount", wallet.Amount);
                command.ExecuteNonQuery();

            }
        }

        public Wallet? GetWalletByCustomerId(int customerId)
        {
           using (var connection = foodContext.CreateConnection())
            {
                var qry = @"Queries\Wallet\getWalletById.sql";
                var command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue(@"CustomerId", customerId);
               var reader = command.ExecuteReader();


                if (reader.Read())
                {
                    return new Wallet
                    {
                        Id = reader.GetInt32(0),
                        CustomerId = reader.GetInt32(1),
                        Amount = reader.GetDouble(2)
                    };
                }
            }  
            return null;
        }
    }
}