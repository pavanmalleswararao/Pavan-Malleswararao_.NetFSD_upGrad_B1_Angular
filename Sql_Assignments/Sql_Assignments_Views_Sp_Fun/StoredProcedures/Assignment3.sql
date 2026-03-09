create procedure sp_EnrollStudent (@StudentID int,
@CourseID int)
as
begin

declare @nextEnrollID int
select @nextEnrollID=ISNULL(max(EnrollmentID),0)+1 from Enrollments
insert into Enrollments (EnrollmentID,StudentID,CourseID,EnrollmentDate) 
values(@nextEnrollID,@StudentID,@CourseID,GETDATE())
end
--Insert data into Enrollments table
exec sp_EnrollStudent @StudentID=101,@CourseID=205
--Automatically use current date
select * from Enrollments order by EnrollmentDate desc