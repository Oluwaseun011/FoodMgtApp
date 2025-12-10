using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Models.Enums;
using Mysqlx.Crud;

namespace FoodDeliveryApp.Models.Entities
{
    public class Order
    {
        public int Id {get;set;}
        public string RefNumber { get; set; } = default!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        public Status Status { get; set; }
        public int DeliveryId { get; set; }
        public Delivery Delivery{ get; set; } = default!;
        public DateTime DateCreated {get;set;} = DateTime.UtcNow!;
        public ICollection<OrderFood> OrderFoods {get; set;} = new HashSet<OrderFood>(); 
    }
}