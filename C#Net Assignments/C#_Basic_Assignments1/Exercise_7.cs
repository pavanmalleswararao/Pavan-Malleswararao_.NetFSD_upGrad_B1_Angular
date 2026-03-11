using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignments1
{
    internal class Exercise_7
    {
        public void CalculateTime()
        {
            Console.WriteLine("Enter Distance:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Speed:");
            int s = Convert.ToInt32(Console.ReadLine());
            int t = d / s;
            Console.WriteLine("Time Taken: " + t);
        }
    }
}
