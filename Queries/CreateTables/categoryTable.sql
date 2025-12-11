create table if not exists categories
(
    Id int auto_increment,
    KitchenId int,
    Name varchar(60),
    primary key(Id),
    foreign key(KitchenId) references kitchens(Id)
);
        