using System;
using System.Collections.Generic;
using System.Text;

namespace Ado_Assignment.Assignment1
{
    internal interface IStudent
    {
        void AddStudent(StudentDetails studentDetails);
        List<StudentDetails>? GetAllStudents();
        void UpdateStudent(int  Id,char Grade);
        void DeleteStudent(int Id);
    }
}
