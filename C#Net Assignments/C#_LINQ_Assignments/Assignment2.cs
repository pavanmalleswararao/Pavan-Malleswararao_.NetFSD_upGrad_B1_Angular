using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments
{
    internal class Assignment2
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            var even = numbers.Where(n => n % 2 == 0);
            foreach (var i in even)
                Console.WriteLine(i);
            Console.WriteLine();

            var greater = numbers.Where(n => n > 15);
            foreach (var n in greater)
                Console.WriteLine(n);
            Console.WriteLine();

            var square = numbers.Select(n => n * n);
            foreach (var i in square)
                Console.WriteLine(i);
            Console.WriteLine();

            var divisible = numbers.Count(n => n % 5 == 0);
            Console.WriteLine(divisible);
        }
    }
}
