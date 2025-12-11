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
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        public Status Status { get; set; }
        public int DeliveryId { get; set; }
        public Delivery Delivery{ get; set; } = default!;
        public DateTime DateCreated {get;set;} = DateTime.UtcNow!;
        public ICollection<OrderFood> OrderFoods {get; set;} = new HashSet<OrderFood>();

        
    }
    public record MakeOrderRequestModel(Dictionary<int, Dictionary<int, int>> Products );
    public record MakeOrderResponseModel(int Id, string RefNumber);
}