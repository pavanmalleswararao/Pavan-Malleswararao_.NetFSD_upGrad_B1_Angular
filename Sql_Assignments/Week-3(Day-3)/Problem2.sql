create table Brand(
brand_id int primary key,
brand_name varchar(20)
)

create table Category(
category_id int primary key,
category_name varchar(20)
)

create table Products(
Product_id int primary key identity(100,1),
brand_id int,
category_id int,
product_name varchar(20),
model_year date not null,
list_price int
foreign key (brand_id) references Brand(brand_id),
foreign key (category_id) references Category(category_id)
)


insert into Products(brand_id,category_id,product_name,model_year,list_price)
values(12, 21, 'S25','2025',599),
(11, 22, 'M4','2025',999),
(13, 23, 'Sony WH','2025',399)


insert into Brand values
(11,'Apple'),
(12,'SamSung'),
(13,'Sony')

insert into Category values
(21,'Mobile'),
(22,'Laptop'),
(23,'Headphones')

-- problem 2
select p.product_name, b.brand_name, c.category_name, p.model_year,p.list_price
from Products p join Brand b on p.brand_id=b.brand_id join Category c on p.category_id=c.category_id
where p.list_price>500 order by list_price asc