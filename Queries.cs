using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public string Kitchens = "create table if not exist (Kitchen, id auto_increament, Name varchar (60) not null, Description varchar (200), CreatedBy varchar (60), DateCreated datetime, IsDeleted tinyint)";
        public string Managers = "create table if not exist (Manager, id auto_increament, Email varchar (100) not null, Name varchar (60) not null, KitchenId int, CreatedBy varchar (60), DateCreated datetime, IsDeleted tinyint)";
    }
}