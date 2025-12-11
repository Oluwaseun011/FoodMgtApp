create table if not exists customers
(
    Id int auto_increment, 
    Name varchar(50),
    Email varchar(50) unique, 
    Address int, 
    primary key(id) 
);