create procedure sp_DeleteStudent(@studentID int)
as
begin
begin try
delete from Students where StudentID=@studentID
print 'Deleted Student'
end try
begin catch
print 'Error: '+ERROR_MESSAGE()
end catch
end


exec sp_DeleteStudent 121