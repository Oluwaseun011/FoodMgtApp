using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;

namespace FoodMgtApp.Repositories.Interfaces
{
    public interface IWalletRepository
    {
        void AddWallet(Wallet wallet);
        Wallet? GetWalletByCustomerId(int customerId);
    }
}