create table products1(
product_id int primary key identity(1,1),
product_name varchar(20)
)

create table storestables(
store_id int primary key,
store_name varchar(20)
)

create table order_items(
product_id int,
quantity int,
foreign key (product_id) references products1(product_id)
)

create table Stock(
product_id int,
store_id int,
quantity int,
foreign key (product_id) references products1(product_id),
foreign key (store_id) references storestables(store_id)
)

insert into products1(product_name) values
('Burgers'),
('Fries'),
('Soda')

insert into storestables values
(1,'DownTown'),
(2,'upTown')

insert into Stock values
(1,1,50),
(2,1,30),
(1,2,45)

insert into order_items values
(1,5),
(1,10),
(3,2)

--problem 4
select p.product_name, st.store_name,s.quantity as available_Stock,
isnull(sum(oi.quantity),0) as total_quantity_sold
from Stock s join products1 p on s.product_id=p.product_id join storestables st on s.store_id=st.store_id
left join order_items oi on p.product_id=oi.product_id group by p.product_name, st.store_name,s.quantity
order by p.product_name