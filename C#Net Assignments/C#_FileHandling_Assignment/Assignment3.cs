using System;
using System.Collections.Generic;
using System.Text;

namespace C__FileHandling_Assignment_Mini_Notepad     
{
    internal class MiniNotepad
    {
        static void Main()
        {
            string filePath = "";
            while (true)
            {
                Console.WriteLine("\n1.Create File");
                Console.WriteLine("2.Write to File");
                Console.WriteLine("3.Read File");
                Console.WriteLine("4.Append Text");
                Console.WriteLine("5.Delete File");
                Console.WriteLine("6.Exit");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("Enter File Name: ");
                                filePath = Console.ReadLine() + ".txt";
                                File.Create(filePath).Close();
                                Console.WriteLine("File is Created");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter Text (Type END to stop)");
                                using (StreamWriter sw = new StreamWriter(filePath))
                                {
                                    string line;
                                    while ((line = Console.ReadLine()) != "END")
                                    {
                                        sw.WriteLine(line);
                                    }
                                }
                                break;
                            }
                        case 3:
                            {
                                using (StreamReader sr = new StreamReader(filePath))
                                {
                                    Console.WriteLine("\nFile Content:");
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                                break;
                            }
                        case 4:
                            {
                                using (StreamWriter sw = new StreamWriter(filePath))
                                {
                                    string line;
                                    while ((line = Console.ReadLine()) != "END")
                                    {
                                        sw.WriteLine(line);
                                    }
                                }
                                break;
                            }
                        case 5:
                            {
                                File.Delete(filePath);
                                Console.WriteLine("File Deleted");
                                break;
                            }
                        case 6:
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
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not Found");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Access Denied");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
