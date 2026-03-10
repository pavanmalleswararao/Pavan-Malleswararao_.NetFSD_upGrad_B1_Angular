	create procedure sp_DisplayStudentCursor
	as
	begin
	declare @Id int,@FName varchar(20),@LName varchar(20)
	declare stu_cursor cursor for select StudentID,FirstName,LastName from Students
	open stu_cursor 
	fetch next from stu_cursor into @Id,@FName,@LName
	while @@FETCH_STATUS=0
	begin
	print 'StudentID: '+cast(@Id as varchar)+' | Name: '+@FName+' '+@LName
	fetch next from stu_cursor into @Id,@FName,@LName
	end
	close stu_cursor
	deallocate stu_cursor
	end

	exec sp_DisplayStudentCursor