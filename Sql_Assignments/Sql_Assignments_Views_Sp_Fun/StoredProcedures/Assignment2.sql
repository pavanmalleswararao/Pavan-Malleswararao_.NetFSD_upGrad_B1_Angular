create procedure sp_GetStudentsByDepartment(@DepartmentID int)
as
begin
select StudentID,(FirstName+' '+LastName) as StudentName, AdmissionDate from Students where DepartmentID=@DepartmentID
end
--Execute procedure for DepartmentID = 2
exec sp_GetStudentsByDepartment 2
--Execute for DepartmentID = 3