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
        public string Name {get;set;} = null!;
        public int StaffNo {get;set;}
        public string Email {get;set;} = null!;
        public string PhoneNumber {get;set;} = null!;
         public bool IsDeleted {get;set;} = false;
        public string CreatedBy {get;set;} = null!;
        public DateTime DateCreated {get;set;} = DateTime.Now;
        public Supervisor(int branchId,string name,int staffNo,string email,string phoneNumber,string createdBy)
        {
            BranchId = branchId;
            Name = name;
            StaffNo = staffNo;
            Email = email;
            PhoneNumber = phoneNumber;
            CreatedBy = createdBy;
        }
        
    }
}