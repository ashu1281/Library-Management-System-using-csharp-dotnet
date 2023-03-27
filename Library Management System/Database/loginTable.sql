create table loginTable(
id int NOT NULL IDENTITY(1,1) primary key,
username varchar(150) not null,
pass varchar(150) not null
)

insert into loginTable (username, pass) values ('ashish', 'pass');
insert into loginTable (username, pass) values ('bablu', 'bablu');
insert into loginTable (username, pass) values ('shubham', 'shubham');
select * from loginTable
