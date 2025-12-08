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
            using(var con = foodContext.CreateConnectionString())
            {
                var query = "insert into wallets(CustomerId,Amount) values (@CustomerId,@Amount)";
                var command = new MySqlCommand(query,con);
                command.Parameters.AddWithValue("@CustomerId",wallet.CustomerId);
                command.Parameters.AddWithValue("@Amount",wallet.Amount);

                command.ExecuteNonQuery();
            }
        }

        public Wallet? GetWalletByCustomerId(int customerId)
        {
            using(var con = foodContext.CreateConnectionString())
            {
                var query = "select * from wallet where CustomerId = @CustomerId";
                var command = new MySqlCommand(query,con);
                var reader = command.ExecuteReader();
                if(reader.Read())
                {
                    var wallet = new Wallet(
                        reader.GetInt32(1)
                    );
                    return wallet;
                }
                return null;
            }
        }
    }
}