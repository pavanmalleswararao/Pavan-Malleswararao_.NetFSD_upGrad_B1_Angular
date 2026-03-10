create table StudentAudit (
AuditId int primary key identity(1,1),
StudentID int,
ActivationType varchar(20),
ActionDate date
)


create trigger trg_StudentInsertAudit
on Students
after insert
as
begin
insert into StudentAudit(StudentID,ActivationType,ActionDate)
select StudentID, 'INSERT', GETDATE()
from inserted
end

insert into Students (StudentID, FirstName, LastName, Gender, DepartmentID, AdmissionDate) values (150,'Pavan','Pachigolla','M',1,GETDATE())

select * from StudentAudit