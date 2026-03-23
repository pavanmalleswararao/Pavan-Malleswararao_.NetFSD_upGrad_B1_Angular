using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignments
{
    internal class Assignment6
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };
            var unique = numbers.Distinct();
            foreach (var num in unique)
                Console.WriteLine(num);
            Console.WriteLine();

            var duplicate = numbers.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key);
            foreach (var num in duplicate)
                Console.WriteLine(num);
            Console.WriteLine();

            var count = numbers.GroupBy(n => n).Select(g => new { Number = g.Key, Count = g.Count() });
            foreach (var num in count)
                Console.WriteLine(num);
        }
    }
}
