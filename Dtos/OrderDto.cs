using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Models.Enums;

namespace FoodMgtApp.Dtos
{
    public class OrderDto
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

        
    }
    public record OrderRequest(Dictionary<int, Dictionary<int, int>> Products );
    public record OrderResponse(int Id, string RefNumber);
}