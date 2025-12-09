using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FoodMgtApp.Models.Enums;
using Mysqlx.Crud;

namespace FoodDeliveryApp.Models.Entities
{
    public class Order
    {
        public int Id {get;set;}
        public string RefNumber { get; set; } = default!;
        public int CustomerId { get; set; } = default!;
        public Status Status { get; set; }
        public int DeliveryId { get; set; } = default!;
        public Dictionary<int, Dictionary<int, int>> Products = new Dictionary<int, Dictionary<int, int>>();
        public DateTime DateCreated {get;set;} = DateTime.UtcNow!;
        public string CreatedBy {get;set;} = default!;
        public bool IsDeleted {get;set;} = false;
        public Customer Customer { get; set; } = default!;
        public Delivery Delivery{ get; set; } = default!;

        private string convert = JsonSerializer.Serialize()

        public Order(int id ,string refNumber,int customerId,Status status, int deliveryId,Dictionary<int,Dictionary<int,int>> products,string createdBy)
        {
            RefNumber = refNumber;
            Id = id;
            CustomerId = customerId;
            Status = status;
            DeliveryId = deliveryId;
            Products = products;
            CreatedBy = createdBy;
        }
    }
}