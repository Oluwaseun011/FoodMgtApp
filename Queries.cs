using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public string KitchenTable = "create table if not exist Kitchens (Id int auto_increament, Name varchar (60) unique not null, Description varchar (200), CreatedBy varchar (60), DateCreated datetime, IsDeleted tinyint, primary key(Id))";
        public string ManagerTable = "create table if not exist Managers (Id int auto_increament, Email varchar (100) unique not null, Name varchar (60) not null, KitchenId int, CreatedBy varchar (60), DateCreated datetime, IsDeleted tinyint, primary key(Id), foreign key(KitchenId) references Kitchens (id) )";
    }
}