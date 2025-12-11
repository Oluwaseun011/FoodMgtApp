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
        public void AddWallet(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public Wallet? GetWalletByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}