	create procedure sp_EnrollStudentTransaction (@StuId int, @courseId int)
	as
	begin
	begin transaction 
	begin try 
	insert into Enrollments (StudentID,CourseID,EnrollmentDate)
	values(@StuId,@courseId,GETDATE())
	commit transaction
	print 'Enrollment Commited'
	end try
	begin catch
	rollback transaction
	print 'Enrollment Rolled Back'+ERROR_MESSAGE()
	end catch
	end


	exec sp_EnrollStudentTransaction 32,101