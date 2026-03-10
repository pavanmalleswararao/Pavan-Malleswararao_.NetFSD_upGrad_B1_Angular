create procedure sp_InsertMarks(
@studentID int,
@examID int,
@marksObtained int)
as
begin
if @marksObtained<0 or @marksObtained>100
begin
raiserror('Invalid marks',16,1)
end
else
begin
declare @markID int
select @markID=isnull(max(MarkID),0)+1 from Marks
insert into Marks(MarkID,StudentID,ExamID,MarksObtained)
values(@markID,@studentID,@examID,@marksObtained)
end
end

exec sp_InsertMarks 101,1,85