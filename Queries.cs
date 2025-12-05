using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    public class Queries
    {
        public const string foodmgtapp = "create schema if not exists foodmgtapp";
        public const string userrole = "create table if not exists userroles(Id int auto_increment, UserId int, RoleId int, primary key(Id), foreign key(UserId) references user(Id), foreign key(RoleId) references role(Id) );";
        }
}
