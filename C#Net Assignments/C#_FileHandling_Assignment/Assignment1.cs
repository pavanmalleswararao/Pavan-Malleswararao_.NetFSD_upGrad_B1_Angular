using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace C__FileHandling_Assignment_Employee_Log_Management_System
{
    internal class EmployeeLog
    {
        static string filePath = "employee_log.txt";

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1.Add Login Entry");
                Console.WriteLine("2.Update Logout Time");
                Console.WriteLine("3.View Logs");
                Console.WriteLine("4.Exit");

                int Choice=int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        {
                            AddLogin();
                            break;
                        }
                    case 2:
                        {
                            UpdateLogout();
                            break;
                        }
                    case 3:
                        {
                            ViewLogs();
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                }
            }
        }
        static void AddLogin()
        {
            Console.WriteLine("Enter Employee ID:");
            string Id=Console.ReadLine();

            Console.WriteLine("Enter Name: ");
            string Name=Console.ReadLine();

            string LoginTime = DateTime.Now.ToString();
            string LogOutTime = "Not Logged Out";

            try
            {
                using (StreamWriter sw=new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{Id} | {Name} | {LoginTime} | {LogOutTime}");
                }
                Console.WriteLine("Login Recorded");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
        }
        static void UpdateLogout()
        {
            Console.WriteLine("Enter Employee ID:");
            string Id = Console.ReadLine();

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File Not Exist");
                    return;
                }
                var lines = File.ReadAllLines(filePath).ToList();
                
                for(int i = 0; i < lines.Count; i++)
                {
                    var parts = lines[i].Split('|');
                    if (parts[0].Trim() == Id && parts[3].Trim() == "Not Logged Out")
                    {
                        parts[3] = DateTime.Now.ToString();
                        lines[i] = string.Join('|', parts);
                        break;
                    }
                }
                File.WriteAllLines  (filePath, lines);
                Console.WriteLine("LogOut Updated");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        static void ViewLogs()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                        Console.WriteLine(line);
                }
                else
                {
                    Console.WriteLine("File Not Found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
