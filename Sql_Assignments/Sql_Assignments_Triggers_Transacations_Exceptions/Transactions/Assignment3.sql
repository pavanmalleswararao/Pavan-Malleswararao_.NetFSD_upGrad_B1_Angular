create procedure sp_TransferStudentDepartment(@stuId int, @newDeptId int)
as
begin
begin transaction
begin try
if exists(select 1 from Departments where DepartmentID=@newDeptId)
throw 50000,'Target Department does not exist.',1
update Students set DepartmentID=@newDeptId where StudentID=@stuId
commit transaction
print 'Transfer Successful.'
end try
begin catch
rollback transaction
print 'Transfer Failed: '+ERROR_MESSAGE()
end catch
end

exec sp_TransferStudentDepartment 102,2