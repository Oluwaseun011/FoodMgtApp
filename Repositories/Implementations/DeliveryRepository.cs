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
    public class DeliveryRepository : IDeliveryRepository
    {
        public void Add(Delivery delivery)
        {
            throw new NotImplementedException();
        }

        public Delivery? Get(string email)
        {
            throw new NotImplementedException();
        }

        public List<Delivery> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}