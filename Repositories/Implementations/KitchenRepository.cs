using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Context;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;

namespace FoodMgtApp.Repositories.Implementations
{
    public class KitchenRepository : IKitchenRepository
    {
        public void Add(Kitchen kitchen)
        {
            throw new NotImplementedException();
        }

        public Kitchen? Get(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Kitchen> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string name)
        {
            throw new NotImplementedException();
        }
    }
}