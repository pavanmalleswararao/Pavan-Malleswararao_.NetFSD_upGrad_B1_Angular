create procedure sp_GetStudentMarks (@StudentID int)
as
begin
select (s.FirstName+' '+s.LastName) as StudentName,
CourseName,ExamType,MarksObtained from Students s join Marks m
on s.StudentID=m.StudentID join Exams e on m.ExamID=e.ExamID 
join Courses c on e.CourseID=c.CourseID where s.StudentID=@StudentID
end

exec sp_GetStudentMarks 105