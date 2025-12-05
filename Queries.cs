using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string branch = "create table if not exist Branches(int Id not null auto_increment unique,KitchenId int not null, Name varchar(20) not null,CreatedBy varchar(20)not null,State varchar(20) not null,TimeCreated dateTime,IsDeleted tinyint,primary key (Id),foreign key(KitchenId) references Branch(KitchenId)";
        public const string Supervisor = "create table if not exist Supervisors(Id int not null auto_increment unique,email varchar(25) unique not null,name varchar(30) not null,KitchenId int not null,CreatedBy varchar(20) not null,IsDeleted tinyint not null,DateCreated dateTime not null,primary key(Id),foreign key(KitchenId) references Manager(KitchenId)";
        public const string schema = "create schema if not exists foodmgtapp";
        public const string deliverytables = "create table if not exists Deliveries(Id int auto_increment, Name varchar(50) not null unique, PlateNumber varchar(50) not null unique, IsAvailable tinyint, CreatedBy varchar(50) DateCreated datetime, IsDeleted tinyint, primary key(Id))";
        public const string ordertables = "create table if not exists Orders(Id int auto_increment, RefNumber varchar(50) not null unique, CustomerId int not null, Status int not null, DeliveryId int not null, Products varchar(50), DateCreated datetime, CreatedBy varchar(50), IsDeleted tinyint, Customer int not null, Delivery int not null, primary key(Id), foreign key(CustomerId) references Customers(Id), foreign key(DeliveryId) references Deliveries(Id))";
        public const string user = "create table if not exists users(Id int auto_increment, Email varchar(50) not null unique, Password varchar(50) not null, CreatedBy varchar(50) not null, DateCreated datetime, IsDeleted tinyint, primary key(id))";
        public const string role = "create table if not exists roles(Id int auto_increment, Name varchar(50) not null, CreatedBy varchar(50) not null, DateCreated datetime, IsDeleted tinyint, primary key(id))";
        public const string CategoryTables = "create table if not exist categories(Id int auto_increment,Name varchar(60),primary key(id));";
        public const string FoodTables = "create table if not exist foods(Id int auto_increment,Name varchar(60)) not null,Discription varchar(100),Price decimal  not null,Quantity int, primary key(id), foreign key(CategoryId) references category(Id)); ";
        public const string KitchenTable = "create table if not exist Kitchens (Id int auto_increament, Name varchar (60) unique not null, Description varchar (200), CreatedBy varchar (60), DateCreated datetime, IsDeleted tinyint, primary key(Id))";
        public const string ManagerTable = "create table if not exist Managers (Id int auto_increament, Email varchar (100) unique not null, Name varchar (60) not null, KitchenId int, CreatedBy varchar (60), DateCreated datetime, IsDeleted tinyint, primary key(Id), foreign key(KitchenId) references Kitchens (id) )";  
        public const string customertable = "create table if not exists Customers(Id int auto_increment, Name varchar(50),Email varchar(50) unique, Address int, primary key(id) );";
        public const string wallettable = "create table if not exists Wallets(Id int auto_increment, CustomerId int not null unique, Amount double not null, primary key(Id), foreign key(CustomerId) refernces Customer(Id))";
        public const string userrole = "create table if not exists userroles(Id int auto_increment, UserId int, RoleId int, primary key(Id), foreign key(UserId) references user(Id), foreign key(RoleId) references role(Id) );";
     }
}
