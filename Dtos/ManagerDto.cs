using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodMgtApp.Dtos
{
    public class ManagerDto
    {
        public int userId {get; set;}
        public string Email {get; set;} = default!;
        public string Password {get; set;} = default!;
        public string CreatedBy {get; set;} = default!;
        public bool IsDeleted {get; set;}
        public DateTime DateCreated {get; set;}
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int KitchenId { get; set; }
    }

    public record ManagerRequest(string Email, string Password, string Name);
    public record ManagerResponse(int Id, string Name);
}