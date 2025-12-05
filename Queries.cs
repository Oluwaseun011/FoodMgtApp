using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string customertable = "create table if not exists Customer(Id int auto_increment, Name varchar(50),Email varchar(50) unique, primary key(id) );";
        public const string wallettable = "create table if not exists Wallet(Id int auto_increment, CustomerId int not null unique, Amount double not null, primary key(Id), foreign key(CustomerId) refernces Customer(Id))";
    }
}