insert into kitchens(
    Id int auto_increment,
    Name varchar(30) uniqe,
    RefNumber varchar(7),
    Email varchar(25),
    PhoneNumber varchar(14),
    IsDeleted tinyint,
    CreatedBy varchar (10),
    DateCreated DateTime,

    primary key(Id)
);