create table if not exists users
(
    Id int auto_increment, 
    Email varchar(50) unique, 
    Password varchar(50) not null, 
    CreatedBy varchar(50) not null, 
    DateCreated datetime default(sysdate()), 
    IsDeleted tinyint default(1), 
    primary key(id)
);