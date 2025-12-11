create table if not exists orderFoods
(
    Id int auto_increment, 
    OrderId int, 
    FoodId int, 
    Quantity int, 
    primary key(Id), 
    foreign key(OrderId) references orders(Id), 
    foreign key(FoodId) references foods(Id) 
);