create function fn_GetTotalMarks(@StudentId int)
returns int
as
begin
declare @TotalMarks int
select @TotalMarks=sum(MarksObtained) from Marks where StudentID=@StudentId
return @TotalMarks
end

select dbo.fn_GetTotalMarks(105)