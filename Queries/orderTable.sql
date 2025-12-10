create table if not exists orders
(
    Id int auto_increment, 
    RefNumber varchar(50) unique, 
    CustomerId int not null, 
    Status int not null, 
    DeliveryId int not null, 
    DateCreated datetime default(sysdate()),
    primary key(Id), 
    foreign key(CustomerId) references customers(Id), 
    foreign key(DeliveryId) references deliveries(Id)
);