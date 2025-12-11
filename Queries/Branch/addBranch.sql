insert into branches 
(
    Id int auto_increment,
    KitchenId int,
    RefNumber varchar(40) unique,
    Email varchar(60) unique,
    State int,
    IsDeleted tinyint default(1),
    CreatedBy varchar(40),
    DateCreated datetime,
    primary key(id),
    foreign key(KitchenId) references kitchens(id)
);