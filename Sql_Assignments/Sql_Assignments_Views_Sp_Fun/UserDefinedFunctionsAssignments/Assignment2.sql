create function fn_GetStudentAge(@DateofBirth date)
returns int
as
begin
declare @Age int
set @Age=DATEDIFF(YEAR,@DateofBirth,GETDATE())
return @Age
end

select dbo.fn_GetStudentAge('2003-08-29')