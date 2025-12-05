using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string CategoryTables = "create table if not exist category(Id int auto_increment,Name varchar(60));";
        public const string FoodTables = "create table if not exist food(Id int auto_increment,Name varchar(60)) not null,Discription varchar(100),Price decimal  not null,Quantity int, primary key(id), foreign key(CategoryId) references category(Id)); ";
    }
}