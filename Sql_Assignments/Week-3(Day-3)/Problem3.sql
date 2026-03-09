create table Stores(
store_id int primary key identity(10,1),
store_name varchar(20)
)

create table Orders1(
order_id int primary key identity(20,1),
order_status int,
store_id int,
foreign key (store_id) references Stores(store_id)
)

create table Order_item(
order_id int,
quantity int,
list_price int,
discount int,
foreign key (order_id) references orders1(order_id)
)

insert into Stores (store_name)
values('KFC'),
('MCDONALES'),
('BARGUR KING')

insert into Orders1(order_status,store_id) values
(1,11),
(2,10),
(3,12),
(4,10),
(5,11)


insert into Order_item values
(21,10,150,10),
(23,15,200,20),
(20,12,180,15),
(23,10,200,10)

--problem 3
select s.store_name,
SUM(oi.quantity * oi.list_price * (1 - oi.discount/100.0)) as TotalSales
from Stores s join Orders1 o on s.store_id=o.store_id join Order_item oi on o.order_id=oi.order_id
where o.order_status=4 group by s.store_name order by TotalSales desc