--Assignment-5
select s.* from Students s join Departments d on s.DepartmentID=d.DepartmentID where d.DepartmentName='Computer Science'

select * from Teachers where HireDate>'2022-12-31'

select * from Students	where FirstName like 'A%'

select * from Courses where Credits>3

select * from Students where DateOfBirth between '2005-01-01' and '2008-12-31'

select s.* from Students s join Departments d on s.DepartmentID=d.DepartmentID where d.DepartmentName!='Mechanical'

select * from Teachers where Salary between 40000 and 70000

select c.* from Courses c join Teachers t on c.TeacherID=t.TeacherID where t.TeacherID!=3