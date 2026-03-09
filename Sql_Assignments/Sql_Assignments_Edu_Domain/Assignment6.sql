--Assignment-6
select d.DepartmentName,count(StudentID) as NoOfStudents from Students s join Departments d on s.DepartmentID=d.DepartmentID group by d.DepartmentName

select e.ExamType,AVG(m.MarksObtained) as AverageMarks from Marks m join Exams e on m.ExamID=e.ExamID group by e.ExamType

select c.CourseName,sum(e.StudentID) as EnrollementCount from Enrollments e join Courses c on e.CourseID=c.CourseID group by c.CourseName

select e.ExamType,max(m.MarksObtained) as MaximumMarks from Marks m join Exams e on m.ExamID=e.ExamID group by e.ExamType

select e.ExamType,min(m.MarksObtained) as MinimumMarks from Marks m join Exams e on m.ExamID=e.ExamID group by e.ExamType

select d.DepartmentName, count(StudentID) as NoOfStudents from Students s join Departments d on s.DepartmentID=d.DepartmentID group by d.DepartmentName having count(s.StudentID)>5
