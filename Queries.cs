using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string CategoryTables = "create table if not exist categories(Id int auto_increment,Name varchar(60),primary key(id));";
        public const string FoodTables = "create table if not exist foods(Id int auto_increment,Name varchar(60)) not null,Discription varchar(100),Price decimal  not null,Quantity int, primary key(id), foreign key(CategoryId) references category(Id)); ";
    }
}