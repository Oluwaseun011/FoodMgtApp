insert into branchFoods(
    Id int auto_increment,
    BranchId int,
    FoodId int,
    Price decimal,
    Quantity int,
    primary key(Id),
    foreign key(BranchId) references branches(Id),
    foreign key(FoodId) references foods(Id)
);
