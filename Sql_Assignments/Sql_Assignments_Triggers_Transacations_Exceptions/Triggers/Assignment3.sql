create table MarksAudit(
AuditID int primary key identity(1,1),
StudentID int,
ExamID int,
OldMarks int,
NewMarks int,
UpdatedDate date default getdate()
)

create trigger trg_UpdateMarksAudit
on Marks
after update
as
begin
insert into MarksAudit(StudentID,ExamID,OldMarks,NewMarks)
select d.StudentID,d.ExamID,d.MarksObtained,i.MarksObtained from deleted d
join inserted i on d.StudentID=i.StudentID and d.ExamID=i.ExamID
end

update Marks set MarksObtained=95 where StudentID=1 and ExamID=1
select * from MarksAudit