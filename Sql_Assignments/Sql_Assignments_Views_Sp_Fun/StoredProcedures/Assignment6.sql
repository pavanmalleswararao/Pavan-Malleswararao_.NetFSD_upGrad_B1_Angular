create procedure sp_DeleteEnrollment (@EnrollmentID int)
as
begin
delete from Enrollments where EnrollmentID=@EnrollmentID
end
--Delete enrollment record
exec sp_DeleteEnrollment 31
--Verify deletion
select * from Enrollments where EnrollmentID=31