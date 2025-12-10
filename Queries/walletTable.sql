create table if not exists wallets
(
    Id int auto_increment, 
    CustomerId int not null, 
    Amount decimal default(0), 
    primary key(Id), 
    foreign key(CustomerId) references customers(Id)
);