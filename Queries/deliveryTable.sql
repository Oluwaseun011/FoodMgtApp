create table if not exists deliveries
(
    Id int auto_increment, 
    Name varchar(50), 
    Email varchar(50) unique, 
    PlateNumber varchar(50) unique, 
    IsAvailable tinyint default(0), 
    CreatedBy varchar(50), 
    DateCreated datetime default(sysdate()), 
    IsDeleted tinyint default(1), 
    primary key(Id)
);
        