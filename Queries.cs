using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string schema = "create schema if not exists foodmgtapp";
        public const string kitchens = "create table if not exist kitchens (Id int auto_increament, Name varchar (60) unique not null, Description varchar (200), CreatedBy varchar (60), DateCreated datetime, IsDeleted tinyint, primary key(Id))";
        public const string managers = "create table if not exist Managers (Id int auto_increament, Email varchar (100) unique not null, Name varchar (60) not null, KitchenId int, CreatedBy varchar (60), DateCreated datetime, IsDeleted tinyint, primary key(Id), foreign key(KitchenId) references Kitchens (id) )";  
        public const string categories = "create table if not exist categories(Id int auto_increment,Name varchar(60),primary key(id));";
        public const string foods = "create table if not exist foods(Id int auto_increment,Name varchar(60)) not null,Discription varchar(100),Price decimal  not null,Quantity int, primary key(id), foreign key(CategoryId) references category(Id)); ";
        public const string deliveries = "create table if not exists Deliveries(Id int auto_increment, Name varchar(50) not null unique, PlateNumber varchar(50) not null unique, IsAvailable tinyint, CreatedBy varchar(50) DateCreated datetime, IsDeleted tinyint, primary key(Id))";
        public const string customers = "create table if not exists Customers(Id int auto_increment, Name varchar(50),Email varchar(50) unique, Address int, primary key(id) );";
        public const string wallets = "create table if not exists Wallets(Id int auto_increment, CustomerId int not null unique, Amount double not null, primary key(Id), foreign key(CustomerId) refernces Customer(Id))";
        public const string orders = "create table if not exists Orders(Id int auto_increment, RefNumber varchar(50) not null unique, CustomerId int not null, Status int not null, DeliveryId int not null, Products varchar(50), DateCreated datetime, CreatedBy varchar(50), IsDeleted tinyint, Customer int not null, Delivery int not null, primary key(Id), foreign key(CustomerId) references Customers(Id), foreign key(DeliveryId) references Deliveries(Id))";
        public const string users = "create table if not exists users(Id int auto_increment, Email varchar(50) not null unique, Password varchar(50) not null, CreatedBy varchar(50) not null, DateCreated datetime, IsDeleted tinyint, primary key(id))";
        public const string roles = "create table if not exists roles(Id int auto_increment, Name varchar(50) not null, CreatedBy varchar(50) not null, DateCreated datetime, IsDeleted tinyint, primary key(id))";
        public const string userroles = "create table if not exists userroles(Id int auto_increment, UserId int, RoleId int, primary key(Id), foreign key(UserId) references user(Id), foreign key(RoleId) references role(Id) );";
     }
}
