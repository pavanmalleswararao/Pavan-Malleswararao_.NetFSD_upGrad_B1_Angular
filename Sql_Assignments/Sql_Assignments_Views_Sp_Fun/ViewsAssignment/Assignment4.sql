create view vw_DepartmentStudentCount
as
select  d.DepartmentName, count(s.StudentID) as TotalStudents from Departments d join Students s 
on d.DepartmentID=s.DepartmentID group by DepartmentName
--Retrieve departments with more than 10 students
select * from vw_DepartmentStudentCount where TotalStudents>10
--Sort departments by highest student count
select * from vw_DepartmentStudentCount order by TotalStudents desc