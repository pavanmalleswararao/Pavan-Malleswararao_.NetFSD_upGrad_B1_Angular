create function fn_GetDepartmentStudents(@DepartmentId int)
returns table
as
return(
select StudentID,(FirstName+' '+LastName) as StudentName, AdmissionDate 
from Students where DepartmentID=@DepartmentId
)

select * from dbo.fn_GetDepartmentStudents(3)