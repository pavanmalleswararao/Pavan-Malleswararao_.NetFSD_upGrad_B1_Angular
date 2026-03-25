    using System.Data;
    using Microsoft.Data.SqlClient;

    namespace Ado_Assignment.Assignment2
    {
        internal class Employee
        {
            private SqlConnection? connection = null;
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=NewPraticeDb;Integrated Security=True;Trust Server Certificate=True";

            private SqlCommand? command = null;
            public void InsertEmployee(string name, decimal salary, string dept)
            {
                try
                {
                    using (connection = new SqlConnection(connectionString))    
                    using(command = new SqlCommand("InsertEmployee", connection))
                    {
                    
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@Name", name));
                        command.Parameters.Add(new SqlParameter("@Salary", salary));
                        command.Parameters.Add(new SqlParameter("@Department", dept));
                        connection?.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    connection?.Close();
                }
            }
            public void GetByDepartment(string dept)
            {
                try
                {
                    using (connection = new SqlConnection(connectionString))
                    using(command = new SqlCommand("GetEmployeesByDepartment", connection))
                    {
                    
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Department", dept);
                        connection?.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id:{reader["EmpId"]} Name:{reader["Name"]} Salary:{reader["Salary"]} Department:{reader["Department"]}");
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    connection?.Close();
                }
            }
            public void UpdateSalary(int id, decimal salary)
            {
                try
                {
                    using (connection = new SqlConnection(connectionString))
                    using(command = new SqlCommand("UpdateSalary", connection))
                    {
                    
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@EmpId", id);
                        command.Parameters.AddWithValue("@Salary", salary);
                        connection?.Open();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    connection?.Close();
                }
            }
            public void DeleteEmployee(int Id)
            {
                try
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        string query = "Delete from Employee where EmpId=@EmpId";
                        using (command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmpId", Id);
                            connection?.Open();
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    connection?.Close();
                }
            }
        }
        class Test_Employee
        {
            static void Main()
            {
                try
                {
                    Console.WriteLine("Employee Management!!!");
                    Employee emp = new Employee();
                    do
                    {
                        Console.WriteLine("1. Insert Employee");
                        Console.WriteLine("2. Get Employees by Department");
                        Console.WriteLine("3. Update Salary");
                        Console.WriteLine("4. Delete Employee");
                        Console.WriteLine("5. Exit");
                        Console.WriteLine("Enter choice: ");
                        int ch = int.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Enter Name:");
                                    string Name = Console.ReadLine();
                                    Console.WriteLine("Enter Salary");
                                    decimal Salary = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Department:");
                                    string Department = Console.ReadLine();
                                    emp.InsertEmployee(Name, Salary, Department);
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Enter Department:");
                                    string Department = Console.ReadLine();
                                    emp.GetByDepartment(Department);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Enter Employee Id");
                                    int EmpId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Salary");
                                    decimal Salary = decimal.Parse(Console.ReadLine());
                                    emp.UpdateSalary(EmpId, Salary);
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Enter Employee Id");
                                    int EmpId = int.Parse(Console.ReadLine());
                                    emp.DeleteEmployee(EmpId);
                                }
                                break;
                            case 5:
                                {
                                    Environment.Exit(0);
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Invalid Choice");
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
