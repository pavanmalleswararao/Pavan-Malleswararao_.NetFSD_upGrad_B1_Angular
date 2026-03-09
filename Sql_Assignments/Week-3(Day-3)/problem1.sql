use PractiseDB

create table Customers(
CustomerId int primary key,
FirstName varchar(20),
LastName varchar(20),
City varchar(20)
);

create table Orders(
Order_id int primary key,
order_date datetime,
order_status int,
OrderAmount decimal(10,2),
CustomerId int
foreign key (CustomerId) references Customers(CustomerId)
)

insert into Customers values
(1,'Monika', 'Arora','Hyderabad'),
(2,'Niharika', 'Verma','Chenni'),
(3, 'Vishal', 'Singhal','Delhi'),
(4,'Amitabh', 'Singh','Mumbai'),
(5,'Vivek', 'Bhati','Banglore')

insert into Orders values
(101,'2026-03-20 09:00:00',1,5000,2),
(102,'2026-03-02 09:00:00', 4,7000,1),
(103,'2026-03-15 09:00:00', 1,3000,3),
(104,'2026-03-06 09:00:00',4,9000,5)

--Problem 1
select c.FirstName,c.LastName,o.Order_id,o.order_date,o.order_status
from Customers c join Orders o
on c.CustomerId=o.CustomerId where o.order_status=1 or o.order_status=4 
order by o.order_date desc
