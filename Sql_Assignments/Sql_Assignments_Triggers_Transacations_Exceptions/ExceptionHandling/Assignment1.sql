create procedure sp_AddStudent(
@FirstName varchar(20),
@LastName varchar(20),
@DepartmentID int,
@Gender char(1),
@AdmissionDate date)
as
begin
begin try
insert into Students(FirstName,LastName,DepartmentID,Gender,AdmissionDate)
values (@FirstName,@LastName,@DepartmentID,@Gender,@AdmissionDate)
end try
begin catch
print 'Error Occured: '+ERROR_MESSAGE()
end catch
end
go


exec sp_AddStudent 'Pavan','Pachigolla',1,'M','2020-06-01'

exec sp_AddStudent 'Pavan','Pachigolla',999,'M','2020-06-01'