-- 1.Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>.
select FIRST_NAME as WorkerName from Worker

-- 2.Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.
select UPPER(FIRST_NAME) from Worker

-- 3.Write an SQL query to fetch unique values of DEPARTMENT from Worker table
select DEPARTMENT from Worker group by DEPARTMENT

-- 4.Write an SQL query to print the first three characters of  FIRST_NAME from Worker table.
select SUBSTRING(FIRST_NAME,1,3) as FirstThreeCharacters  from Worker

--5.Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.
select CHARINDEX('a',FIRST_NAME) from Worker where FIRST_NAME='Amitabh'

--6.Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.
select RTRIM(FIRST_NAME) from Worker

--7. Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.
select LTRIM(DEPARTMENT) from Worker

--8. Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.
select LEN(DEPARTMENT) from Worker group by DEPARTMENT

--9. Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘A’.
select REPLACE(FIRST_NAME,'a','A') from Worker

--10. Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them.
select FIRST_NAME+' '+LAST_NAME as COMPLETE_NAME  from Worker

--11. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending.
select * from Worker order by FIRST_NAME asc

--12. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.
select * from Worker order by FIRST_NAME asc,DEPARTMENT desc

--13. Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table.
select * from Worker where FIRST_NAME in ('Vipul','Satish')

--14. Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.
select * from Worker where FIRST_NAME not in ('Vipul','Satish')

--15. Write an SQL query to print details of Workers with DEPARTMENT name as “Admin”.
select * from Worker where DEPARTMENT='Admin'

--16. Write an SQL query to print details of the Workers whose FIRST_NAME contains ‘a’.
select * from Worker where FIRST_NAME like 'a%'

--17. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘a’.
select * from Worker where FIRST_NAME like '%a'

--18. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets.
select * from Worker where FIRST_NAME like '_____h'

--19. Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.
select * from Worker where SALARY between 100000 and 500000

--20. Write an SQL query to print details of the Workers who have joined in Feb’2014.
select * from Worker where JOINING_DATE between '2014-02-01' and '2014-02-28'

--21. Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000.
select FIRST_NAME||' '||LAST_NAME as WorkerName from Worker where SALARY between 100000 and 500000 

--22. Write an SQL query to fetch the no. of workers for each department in the descending order.
select DEPARTMENT, count(*) as NoOfWorkers from Worker group by DEPARTMENT

--23. Write an SQL query to print details of the Workers who are also Managers
select w.* from Worker w
inner join Title t on WORKER_ID=t.WORKER_REF_ID
where t.WORKER_TITLE='Manager'

--24.Write an SQL query to show the current date and time.
select GETDATE() as currentdatetime

--25.Write an SQL query to show the top n (say 10) records of a table.
select top 10 * from Worker