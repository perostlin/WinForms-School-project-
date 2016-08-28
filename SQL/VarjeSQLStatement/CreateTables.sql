use ProjektTestDB

create table Department
(
Id int not null identity(1,1),
Name nvarchar(90) not null,
constraint Department_PK primary key(Id)
)

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