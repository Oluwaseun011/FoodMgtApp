create table if not exists foods
(
    Id int auto_increment,
    Name varchar(60) unique,
    Price decimal not null,
    Quantity int, 
    CategoryId int not null,
    primary key(id), 
    foreign key(CategoryId) references categories(Id)
);
        