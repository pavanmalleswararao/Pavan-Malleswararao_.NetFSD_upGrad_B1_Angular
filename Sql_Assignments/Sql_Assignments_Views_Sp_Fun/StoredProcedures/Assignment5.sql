create procedure sp_UpdateMarks (@marksID int,@NewMarks int)
as
begin
update Marks set MarksObtained=@NewMarks where MarkID=@marksID
end
--Update student marks
exec sp_UpdateMarks 30,95
--Display updated result.
select * from Marks where MarkID=30