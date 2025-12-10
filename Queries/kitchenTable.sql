create table if not exist kitchens 
(
    Id int auto_increament, 
    Name varchar (60) unique, 
    RefNumber varchar (60) unique, 
    Email varchar (60) unique, 
    PhoneNumber varchar (60) unique,
    CreatedBy varchar (60), 
    DateCreated datetime default(sysdate()), 
    IsDeleted tinyint default(1), 
    primary key(Id)
);
        