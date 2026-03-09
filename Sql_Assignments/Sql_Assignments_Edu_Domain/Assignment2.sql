--Assignment-2
alter table Departments add constraint UQ_DepartmentName unique(DepartmentName)

alter table Students add constraint CHK_Gender check(Gender in('M','F'))

alter table Courses add constraint CHK_Creadits check(Credits between 1 and 5)

alter table Marks add constraint CHK_MarksObtain check(MarksObtained between 1 and 100)

alter table Teachers add constraint UQ_Email unique(Email)

alter table Enrollments add default getdate() for EnrollmentDate