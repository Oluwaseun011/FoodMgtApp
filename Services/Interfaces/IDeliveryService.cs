using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Dtos;

namespace FoodMgtApp.Services.Interfaces
{
    public interface IDeliveryService
    {
        public DeliveryResponse? CreateDelivery(DeliveryRequest delivery);
    }
}