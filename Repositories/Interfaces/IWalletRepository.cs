using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IWalletRepository
    {
        void AddWallet(int customerId, decimal initialBalance);
        Wallet? GetWalletByCustomerId(int customerId);
        void CreateWallet(int customerId, decimal initialBalance);
    }
}