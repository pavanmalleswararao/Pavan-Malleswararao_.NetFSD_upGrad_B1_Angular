using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignments1
{
    internal class Exercise_5
    {
        public void HighestNumber()
        {
            Console.WriteLine("Enter 2 Numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("The Highest Number" + a);
            }
            else
            {
                Console.WriteLine("The Highest Number" + b);
            }
        }
    }
}
