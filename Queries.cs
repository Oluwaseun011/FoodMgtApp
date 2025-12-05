using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string deliverytables = "create table if not exists Deliveries(Id int auto_increment, Name varchar(50) not null unique, PlateNumber varchar(50) not null unique, IsAvailable tinyint, CreatedBy varchar(50) DateCreated datetime, IsDeleted tinyint, primary key(Id))";
        public const string ordertables = "create table if not exists Orders(Id int auto_increment, RefNumber varchar(50) not null unique, CustomerId int not null, Status int not null, DeliveryId int not null, Products varchar(50), DateCreated datetime, CreatedBy varchar(50), IsDeleted tinyint, Customer int not null, Delivery int not null, primary key(Id), foreign key(CustomerId) references Customers(Id), foreign key(DeliveryId) references Deliveries(Id))";
    }
}