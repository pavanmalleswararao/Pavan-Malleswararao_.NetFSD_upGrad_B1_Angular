--Assignment-3
alter table Students add PhoneNumber varchar(16)

alter table Teachers add Salary int

alter table Teachers alter column Salary decimal(10,2)

alter table Teachers add constraint CHK_TeachersSalary check (Salary>20000)

alter table Students drop column PhoneNumber

exec sp_rename 'Teachers.TeacherName','FullName','Column'