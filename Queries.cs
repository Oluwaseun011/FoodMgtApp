using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string foodmgtapp = "create schema if not exists foodmgtapp";
        public const string customertable = "create table if not exists Customers(Id int auto_increment, Name varchar(50),Email varchar(50) unique, Address int, primary key(id) );";
        public const string wallettable = "create table if not exists Wallets(Id int auto_increment, CustomerId int not null unique, Amount double not null, primary key(Id), foreign key(CustomerId) refernces Customer(Id))";
        public const string userrole = "create table if not exists userroles(Id int auto_increment, UserId int, RoleId int, primary key(Id), foreign key(UserId) references user(Id), foreign key(RoleId) references role(Id) );";
     }
}
