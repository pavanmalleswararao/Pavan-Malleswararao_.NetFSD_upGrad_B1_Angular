create trigger trg_PreventStudentDelete
on Students
after delete
as
begin
if exists(select 1 from Enrollments where StudentID in (select StudentID from deleted))
begin
RAISERROR('Student has course enrollments and cannot be deleted',16,1)
ROLLBACK 
end
end
go

delete from Students where StudentID=1

delete from Students where StudentID=150