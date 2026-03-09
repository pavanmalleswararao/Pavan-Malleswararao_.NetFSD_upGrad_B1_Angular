--Assignment-7
select s.FirstName,s.LastName,d.DepartmentName from Students s join Departments d on s.DepartmentID=d.DepartmentID

select c.CourseName,t.FullName from Courses c join Teachers t on c.TeacherID=t.TeacherID

select s.FirstName,s.LastName,c.CourseName from Students s join Enrollments e on s.StudentID=e.StudentID join Courses c on e.CourseID=c.CourseID

select s.FirstName,s.LastName,e.ExamType,m.MarksObtained from Students s join Marks m on s.StudentID=m.StudentID join Exams e on m.ExamID=e.ExamID

select c.CourseName,t.FullName as TeacherName from Courses c join Teachers t on c.TeacherID=t.TeacherID

select t.FullName from Teachers t left join Courses c on t.TeacherID=c.TeacherID where c.CourseID is null
