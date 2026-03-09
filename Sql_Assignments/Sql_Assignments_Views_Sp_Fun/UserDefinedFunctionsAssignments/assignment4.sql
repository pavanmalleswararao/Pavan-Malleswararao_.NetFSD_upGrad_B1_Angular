create function fn_GetStudentCourses(@StudentID int)
returns table
as
return(
select c.CourseName,e.EnrollmentDate
from Courses c join Enrollments e 
on c.CourseID=e.CourseID where e.StudentID=@StudentID
)

select * from dbo.fn_GetStudentCourses(102)