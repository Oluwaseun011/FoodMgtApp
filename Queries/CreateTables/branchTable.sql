create table if not exists branches
(
    Id int auto_increment,
    KitchenId int not null, 
    Name varchar(20) not null,
    RefNumber varchar(60) unique, 
    Email varchar(60) unique, 
    PhoneNumber varchar(14) unique,
    State int not null,
    IsDeleted tinyint default(1), 
    CreatedBy varchar(20) not null,
    DateCreated datetime default(sysdate()), 
    primary key (Id),
    foreign key(KitchenId) references kitchens(Id)
);