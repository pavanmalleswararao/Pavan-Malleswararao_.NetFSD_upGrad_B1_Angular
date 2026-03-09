create view vw_ExamResults
as
select (s.FirstName+s.LastName) as StudentName,c.CourseName,e.ExamType,m.MarksObtained from Students s join Marks m
on s.StudentID=m.StudentID join Exams e on m.ExamID=e.ExamID join Courses c on e.CourseID=c.CourseID
--Retrieve students scoring more than 80
select StudentName from vw_ExamResults where MarksObtained>80
--Retrieve top scorers in each exam
select * from vw_ExamResults v1 where MarksObtained = (select max(MarksObtained) from vw_ExamResults v2 where v1.ExamType=v2.ExamType)
--Find students who failed
select StudentName,CourseName,MarksObtained from vw_ExamResults where MarksObtained<40