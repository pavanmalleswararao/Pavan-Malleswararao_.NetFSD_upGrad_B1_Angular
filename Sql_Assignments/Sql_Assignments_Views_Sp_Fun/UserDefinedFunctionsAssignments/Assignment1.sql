create function fn_GetGrade (@MarksObtained int)
returns varchar(20)
as
begin
declare @grade varchar(10)
set @grade=case
when @MarksObtained>=90 then 'A'
when @MarksObtained>=75 then 'B'
when @MarksObtained>=60 then 'c'
else 'Fail'
end return @grade
end

select dbo.fn_GetGrade(90)