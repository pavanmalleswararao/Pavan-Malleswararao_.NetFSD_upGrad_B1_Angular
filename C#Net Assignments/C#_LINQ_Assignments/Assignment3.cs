using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments
{
    internal class Assignment3
    {
        static void Main()
        {
            List<string> names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };

            var starts = names.Where(n => n.StartsWith("A"));
            foreach (var name in starts)
                Console.WriteLine(name);
            Console.WriteLine();

            var sorted = names.OrderBy(n => n);
            foreach (var i in sorted)
                Console.WriteLine(i);
            Console.WriteLine();

            var upper = names.Select(n => n.ToUpper());
            foreach (var i in upper)
                Console.WriteLine(i);
            Console.WriteLine();

            var length = names.Where(n => n.Length > 4);
            foreach (var name in length)
                Console.WriteLine(name);
        }
    }
}
