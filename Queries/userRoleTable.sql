create table if not exists userroles
(
    Id int auto_increment, 
    UserId int, 
    RoleId int, 
    primary key(Id), 
    foreign key(UserId) references users(Id), 
    foreign key(RoleId) references roles(Id) 
);