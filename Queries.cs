using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string branch = "create table if not exist Branch(int Id not null auto_increment unique,KitchenId int not null, Name varchar(20) not null,CreatedBy varchar(20)not null,State varchar(20) not null,TimeCreated dateTime,IsDeleted tinyint,primary key (Id),foreign key(KitchenId) references Branch(KitchenId)";
        public const string Manager = "create table if not exist Manager(Id int not null auto_increment unique,email varchar(25) unique not null,name varchar(30) not null,KitchenId int not null,CreatedBy varchar(20) not null,IsDeleted tinyint not null,DateCreated dateTime not null,primary key(Id),foreign key(KitchenId) references Manager(KitchenId)";
    }
}