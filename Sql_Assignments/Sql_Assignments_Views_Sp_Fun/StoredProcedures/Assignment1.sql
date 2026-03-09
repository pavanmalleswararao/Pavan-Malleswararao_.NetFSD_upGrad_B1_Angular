--Insert a new student
create procedure sp_InsertStudent
(@FirstName varchar(20),
@LastName varchar(20),
@Gender char(1),
@DepartmentId int,
@AdmissionDate date
)
as
begin 
declare @NextID INT;
select @NextID = isnull(MAX(StudentID), 0) + 1 FROM Students;
insert into Students(StudentID,FirstName,LastName,Gender,DepartmentID,AdmissionDate)
values (@NextID,@FirstName,@LastName,@Gender,@DepartmentId,@AdmissionDate)
end
--Execute the procedure
exec sp_InsertStudent @FirstName = 'Pavan', 
    @LastName = 'Pachigolla', 
    @Gender = 'M', 
    @DepartmentID = 1, 
    @AdmissionDate = '2026-03-09'
--Verify inserted data
select * from Students where FirstName='Pavan'