create view vw_StudentCourses
as
select s.StudentID, 
(s.FirstName+s.LastName) as StudentName,c.CourseName , e.EnrollmentDate from Students s join Enrollments e
on s.StudentID=e.StudentID join Courses c on e.CourseID=c.CourseID
--Show courses taken by StudentID = 5
select CourseName from vw_StudentCourses where StudentID=105
--Count courses taken by each student
select StudentName,count(CourseName) as TotalCourses from vw_StudentCourses group by StudentName
--List students enrolled after 2024
select distinct StudentName, EnrollmentDate from vw_StudentCourses where EnrollmentDate>'2024-12-31'