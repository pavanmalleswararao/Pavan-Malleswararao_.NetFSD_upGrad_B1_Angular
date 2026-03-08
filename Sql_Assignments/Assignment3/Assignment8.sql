--Assignment-8
select s.FirstName,s.LastName from Students s join Marks m on s.StudentID=m.StudentID where m.MarksObtained>(select avg(MarksObtained) from Marks)

select CourseName,Credits from Courses where Credits >= all(select max(Credits) from Courses)

select FirstName,LastName from Students where StudentID in(select StudentID from Enrollments group by StudentID having count(CourseID)>2)

select FullName from Teachers where DepartmentID=any(select DepartmentID from Teachers where FullName like 'John%') and FullName not like 'John%'

select s.FirstName,s.LastName, m.MarksObtained from Students s join Marks m on s.StudentID=m.StudentID where MarksObtained = (select max(MarksObtained) from Marks)

select DepartmentName from Departments d where exists (select DepartmentID from Students group by DepartmentID 
having d.DepartmentID=Students.DepartmentID and count(*)=(select max(StudentCount) from(select COUNT(*) as StudentCount 
from Students group by DepartmentID) as T))