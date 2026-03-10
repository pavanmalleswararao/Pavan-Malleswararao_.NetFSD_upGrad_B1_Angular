create procedure sp_CalculateStudentTotalMarks
as
begin
declare @stuId int, @stuName varchar(20), @totalMarks int
declare student_cursor cursor for select StudentID,FirstName+' '+LastName from Students
open student_cursor
fetch next from student_cursor into @stuId,@stuName 
while  @@FETCH_STATUS=0
begin
select @totalMarks=sum(MarksObtained) from Marks where StudentID=@stuId
print 'Student Name: '+@stuName+' | TOtal Marks: '+cast(isnull(@totalMarks,0) as varchar)
fetch next from student_cursor into @stuId,@stuName 
end
close student_cursor
deallocate student_cursor
end

exec sp_CalculateStudentTotalMarks