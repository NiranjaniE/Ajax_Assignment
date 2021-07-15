create database AjaxConcept
Use AjaxConcept
create table dbo.Country
(
Cid int not null identity(1,1) primary key,
Cname varchar(100)
);
create table dbo.State
(
Sid int not null identity(1,1) primary key,
Sname varchar(100),
Cid int
);
create table dbo.City
(
Cityid int not null identity(1,1) primary key,
Cityname varchar(100),
Sid int
);

select * from City
select * from State
select * from Country