using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models.Entities
{
    public class Supervisor
    {
        public int Id {get;set;}
        public int BranchId {get;set;}
        public string Name {get;set;} = default!;
        public string Email {get;set;} = default!;
        public string StaffNo {get;set;}= default!;
         public bool IsDeleted {get;set;} = false;
        public string CreatedBy {get;set;} = null!;
        public DateTime DateCreated {get;set;} = DateTime.Now;

        public Supervisor(int branchId,string name,string staffNo,string email,string createdBy)
        {
            BranchId = branchId;
            Name = name;
            Email = email;
            StaffNo = staffNo;
            CreatedBy = createdBy;
        }
        
    }
}