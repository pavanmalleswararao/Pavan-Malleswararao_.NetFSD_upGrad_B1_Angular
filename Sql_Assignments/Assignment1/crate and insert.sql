create database PractiseDB
use PractiseDB

CREATE TABLE Worker (
	WORKER_ID INT PRIMARY KEY IDENTITY(1,1),
	FIRST_NAME VARCHAR(25),
	LAST_NAME VARCHAR(25),
	SALARY INT,
	JOINING_DATE DATETIME,
	DEPARTMENT CHAR(25)
);
CREATE TABLE Bonus (
	WORKER_REF_ID INT,
	BONUS_AMOUNT INT,
	BONUS_DATE DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);
CREATE TABLE Title (
	WORKER_REF_ID INT,
	WORKER_TITLE CHAR(25),
	AFFECTED_FROM DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);


insert into Worker(FIRST_NAME,LAST_NAME,SALARY,JOINING_DATE, DEPARTMENT) 
values
('Monika', 'Arora',	100000,	'2014-02-20 09:00:00', 'HR'),
('Niharika', 'Verma', 80000, '2014-06-11 09:00:00', 'Admin'),
('Vishal', 'Singhal', 300000, '2014-02-20 09:00:00', 'HR'),
('Amitabh', 'Singh', 500000, '2014-02-20 09:00:00', 'Admin'),
('Vivek', 'Bhati', 500000, '2014-06-11 09:00:00', 'Admin'),
('Vipul', 'Diwan', 200000, '2014-06-11 09:00:00', 'Account'),
('Satish', 'Kumar',  75000, '2014-01-20 09:00:00', 'Account'),
('Geetika','Chauhan', 90000, '2014-04-11 09:00:00',	'Admin');

select * from Worker

insert into Bonus(WORKER_REF_ID,BONUS_DATE,BONUS_AMOUNT)
values
(1,'2016-02-20 00:00:00', 5000),
(2,'2016-06-11 00:00:00',	3000),
(3,'2016-02-20 00:00:00', 4000),
(1,'2016-02-20 00:00:00', 4500),
(2,'2016-06-11 00:00:00', 3500);

select * from Bonus

insert into Title (WORKER_REF_ID,WORKER_TITLE,AFFECTED_FROM)
values
(1,	'Manager',	'2016-02-20 00:00:00'),
(2, 'Executive', '2016-06-11 00:00:00'),
(8, 'Executive', '2016-06-11 00:00:00'),
(5, 'Manager', '2016-06-11 00:00:00'),
(4, 'Asst. Manager', '2016-06-11 00:00:00'),
(7,	'Executive', '2016-06-11 00:00:00'),
(6, 'Lead', '2016-06-11 00:00:00'),
(3,	'Lead',	'2016-06-11 00:00:00');

select *  from Title