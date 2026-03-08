--Assignment-10
CREATE INDEX IDX_STUDENT_LASTNAME ON Students(LastName)

CREATE INDEX IDX_TEACHER_EMAIL ON Teachers(Email)

CREATE INDEX IDX_Enrollment_StudentCourse ON Enrollments(StudentID,CourseID)

CREATE UNIQUE INDEX UQ_IDX_DepartmentName ON Departments(DepartmentName)

DROP INDEX IDX_STUDENT_LASTNAME ON Students