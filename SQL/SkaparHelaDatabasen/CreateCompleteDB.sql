/*Skapar först en databas vid namn ProjektDatabas(Denna finns redan kopplad till ConnectionStringen i systemet*/
create database ProjektDatabas

/*Kör en use för att använda rätt databas*/
use ProjektDatabas

/*Skapar Department-tabellen*/
/*!OBS! Denna måste skapas först !OBS!*/
create table Department
(
Id int not null identity(1,1),
Name nvarchar(90) not null,
constraint Department_PK primary key(Id)
)

/*Skapar Employee-tabellen*/
create table Employee
(
Id int not null identity(1,1),
Firstname nvarchar(50) not null,
Lastname nvarchar(100) not null,
Email nvarchar(255) not null unique,
DateOfBirth datetime not null,
OnParentalLeave bit not null,
DepartmentId int not null,
constraint Employee_PK primary key(Id),
constraint Employee_FK_Department foreign key(DepartmentId) references Department(Id)
)

/*Alla insert-statements för Department-tabellen*/
insert into Department(Name)
values('Customer Service')

insert into Department(Name)
values('Financial')

insert into Department(Name)
values('IT')

insert into Department(Name)
values('R&D')

insert into Department(Name)
values('Sales')

/*Alla insert-statements för Employee-tabellen*/
insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('Anders', 'Aronsson', 'anders@gmail.com', '1976-08-30 19:05:00', 0, 1)

insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('Kurt', 'Melkersson', 'kurt@gmail.com', '1980-02-29 12:05:00', 0, 2)

insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('Sally', 'Johansson', 'sally@gmail.com', '1970-05-23 11:05:00', 0, 3)

insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('Alexander', 'Wikingsson', 'alexander@gmail.com', '1988-12-03 10:05:00', 0, 4)

insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('Greta', 'Garbo', 'greta@gmail.com', '1969-11-07 08:05:00', 0, 5)

insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('Johan', 'Fredriksson', 'johan@gmail.com', '1989-04-02 04:05:00', 0, 1)

insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('Wilhelm', 'Andersson', 'wilhelm@gmail.com', '1985-06-09 09:05:00', 0, 2)

insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('David', 'Carlsson', 'david@gmail.com', '1974-06-01 11:05:00', 0, 3)

insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('Frank', 'Eriksson', 'frank@gmail.com', '1965-08-28 13:05:00', 0, 4)

insert into Employee(Firstname, Lastname, Email, DateOfBirth, OnParentalLeave, DepartmentId)
values('Cissi', 'Brattvik', 'cissi@gmail.com', '1980-09-27 14:05:00', 0, 5)