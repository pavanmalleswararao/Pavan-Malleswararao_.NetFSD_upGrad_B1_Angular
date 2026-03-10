create procedure sp_UpdateCourseCredits
as
begin
declare @courseId int, @credits int
declare credit_cursor cursor for select CourseID,Credits from Courses
open credit_cursor
fetch next from credit_cursor into @courseId,@credits
while @@FETCH_STATUS=0
begin
update Courses set Credits=Credits+1 where CourseID=@courseId
print 'Course '+cast(@courseId as varchar)+ ' udated to '+cast(@credits+1 as varchar) + ' credits. '
fetch next from credit_cursor into @courseId,@credits
end
close credit_cursor
deallocate credit_cursor
end

exec sp_UpdateCourseCredits
select * from Courses
