use drinkDB

drop table if exists UserInfo

create table UserInfo(
UserID int primary key  identity (10000, 1) not null,
Account nvarchar(30) not null unique ,
Password nvarchar(30) not null ,
Name nvarchar(30) not null,
PhoneNumber nvarchar(30) not null,
Address nvarchar(30)
)

create table Shop(
ShopID int primary key identity(100,1),
ShopName nvarchar(30) not null,
Account nvarchar(30) not null unique,
Password nvarchar(30) not null,
ShopPhone nvarchar(30) not null,
ShopAddress nvarchar(30) not null
)

create table Drink(
DrinkID int primary key identity(1000,1),
ShopID int not null,
DrinkName nvarchar(30),
Price int not null,
Stock int not null,
)

create table Feed(
FeedID int primary key identity(2000,1),
ShopID int not null,
FeedName nvarchar(30),
Price int not null,
Stock int not null
)
create table OrderMessage(
OrderID int primary key identity(100000,1),
OrderDate DateTime,
ShopID int,
OrderPrice int ,
OrderConfirm bit ,
OrderMessage nvarchar(30)
)