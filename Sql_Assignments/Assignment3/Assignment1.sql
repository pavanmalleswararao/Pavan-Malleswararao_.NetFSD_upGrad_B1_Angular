create database SchoolManagementDB
use SchoolManagementDB

--Assignment-1
create table Departments(
DepartmentID int primary key,
DepartmentName varchar(20),
Location varchar(20)
)

create table Teachers(
TeacherID int primary key,
TeacherName varchar(20) ,
Email varchar(20),
DepartmentID int,
HireDate date,
foreign key (DepartmentID) references Departments(DepartmentID)
)

create table Students(
StudentID int primary key,
FirstName varchar(20),
LastName varchar(20),
DateOfBirth date,
Gender char(1),
DepartmentID int,
AdmissionDate date,
foreign key (DepartmentID) references Departments(DepartmentID)
)

create table Courses(
CourseID int primary key,
CourseName varchar(20) ,
Credits int ,
DepartmentID  int,
TeacherID int,
foreign key (DepartmentID) references Departments(DepartmentID),
foreign key (TeacherID) references Teachers(TeacherID)
)

create table Enrollments(
EnrollmentID int primary key,
StudentID int,
CourseID int,
EnrollmentDate date,
foreign key (StudentID) references Students(StudentID),
foreign key (CourseID) references Courses(CourseID)
)

create table Exams(
ExamID int primary key,
CourseID int,
ExamDate date,
ExamType varchar(20),
foreign key (CourseID) references Courses(CourseID)
)

create table Marks(
MarkID int primary key,
StudentID int,
ExamID int,
MarksObtained int,
foreign key (StudentID) references Students(StudentID),
foreign key (ExamID) references Exams(ExamID)
)