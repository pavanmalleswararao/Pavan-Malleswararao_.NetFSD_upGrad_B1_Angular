using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignments1
{
    internal class Exercise_1
    {
        public void Divided()
        {
            Console.WriteLine("Enter First value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b != 0)
            {
                Console.WriteLine("Quotient: " + (a / b));
            }
            else
            {
                Console.WriteLine("Second Nuber is not zero");
            }
        }
    }
}
