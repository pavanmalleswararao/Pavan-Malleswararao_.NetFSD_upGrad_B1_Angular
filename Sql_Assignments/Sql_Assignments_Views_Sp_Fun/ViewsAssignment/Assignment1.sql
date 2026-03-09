--Create the view.
create view vw_StudentDepartment
as
select s.StudentID,(s.FirstName||s.LastName) as StudentName ,d.DepartmentName, s.AdmissionDate from Students s join Departments d
on s.DepartmentID=d.DepartmentID
Go
--Retrieve all records from the view
select * from vw_StudentDepartment
--Filter students from Computer Science department using the view
select * from vw_StudentDepartment where DepartmentName='Computer Science'
--Drop the view
drop view vw_StudentDepartment