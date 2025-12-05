using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string user = "create table if not exists users(Id int auto_increment, Email varchar(50) not null unique, Password varchar(50) not null, CreatedBy varchar(50) not null, DateCreated datetime, IsDeleted tinyint, primary key(id))";
        public const string role = "create table if not exists roles(Id int auto_increment, Name varchar(50) not null, CreatedBy varchar(50) not null, DateCreated datetime, IsDeleted tinyint, primary key(id))";

        
    }
}