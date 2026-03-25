using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace Ado_Assignment.Assignment1
{
    internal class Student:IStudent
    {
        private SqlConnection? con = null;
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=NewPraticeDb;Integrated Security=True;Trust Server Certificate=True";
        public Student()
        {
            con = new SqlConnection(connectionString);
        }
        private SqlCommand? cmd= null;
        private string? qry = null;

        public void AddStudent(StudentDetails studentDetails)
        {
            try
            {
                qry = $"Insert into Students values('{studentDetails.Name}',{studentDetails.Age},'{studentDetails.Grade}')";
                cmd = new SqlCommand(qry, con);
                con?.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con?.Close();
            }
        }

        public List<StudentDetails>? GetAllStudents()
        {
            try
            {
                qry = "Select * from Students";
                cmd= new SqlCommand(qry, con);
                con?.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<StudentDetails> students = new List<StudentDetails>();
                while (reader.Read())
                {
                    students.Add( new StudentDetails()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Age = (int)reader["Age"],
                        Grade = Convert.ToChar(reader["Grade"])
                    });
                    
                }
                return students;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con?.Close();
            }
        }

        public void UpdateStudent(int Id, char Grade)
        {
            try
            {
                qry = $"Update Students set Grade='{Grade}' where Id={Id}";
                cmd= new SqlCommand(qry, con);
                con?.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con?.Close();
            }
        }

        public void DeleteStudent(int Id)
        {
            try
            {
                qry = $"Delete from Students where Id='{Id}'";
                cmd = new SqlCommand(qry, con);
                con?.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con?.Close();
            }
        }
    }
    class Test_Student
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Student Management System!!");
                Student s= new Student();
                do
                {
                    Console.WriteLine("1.Add Student");
                    Console.WriteLine("2.Get All Students");
                    Console.WriteLine("3.Update Student");
                    Console.WriteLine("4.Delete Student");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine("Enter your Choice");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            {
                                StudentDetails student= new StudentDetails();
                                Console.WriteLine("Enter Name");
                                student.Name = Console.ReadLine();
                                Console.WriteLine("Enter Age");
                                student.Age = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Grade");
                                student.Grade = Convert.ToChar(Console.ReadLine()); 
                                s.AddStudent(student);
                            }
                            break;
                        case 2:
                            {
                                List<StudentDetails> students = s.GetAllStudents();
                                foreach (var student in students)
                                {
                                    Console.WriteLine($"Id:{student.Id} Name:{student.Name} Age:{student.Age} Grade:{student.Grade}");
                                }
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Enter Id");
                                int Id=int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Grade");
                                char Grade=Convert.ToChar(Console.ReadLine());
                                s.UpdateStudent(Id, Grade);
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Enter Id");
                                int Id = int.Parse(Console.ReadLine());
                                s.DeleteStudent(Id);
                            }
                            break;
                        case 5:
                            {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invaild Choice");
                            }
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
