using System;
using System.Collections.Generic;
using System.Text;

namespace C__FileHandling_Assignment_Student_Report_Card_Generator
{
    internal class StudentReport
    {
        static void Main()
        {
            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Roll Number:");
            string roll = Console.ReadLine();

            int[] marks = new int[3];
            for(int i = 0; i < 3; i++)
            {
                Console.Write($"Enter Marks for Subject {i + 1}: ");
                marks[i]=int.Parse( Console.ReadLine() );
            }

            int total = marks[0] + marks[1] + marks[2];
            double avg = total / 3.0;
            string grade = avg >= 75 ? "A" : avg >= 50 ? "B" : avg >= 35 ? "c" : "Fail";
            string content = $"Student Name: {Name}\n" + $"Roll Number: {roll}\n" + $"Marks: {marks[0]}, {marks[1]}, {marks[2]}\n" + $"Total: {total}\n" + $"Average: {avg}\n" + $"Grade: {grade}";

            try
            {
                File.WriteAllText($"{roll}.txt", content);
                Console.WriteLine("Report Saved!");

                Console.WriteLine("\nEnter Roll Number to Read File:");
                string readroll = Console.ReadLine();

                if (File.Exists($"{readroll}.txt"))
                {
                    string data = File.ReadAllText($"{readroll}.txt");
                    Console.WriteLine("\n---Report---");
                    Console.WriteLine(data);
                }
                else
                    Console.WriteLine("File Not Found");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
