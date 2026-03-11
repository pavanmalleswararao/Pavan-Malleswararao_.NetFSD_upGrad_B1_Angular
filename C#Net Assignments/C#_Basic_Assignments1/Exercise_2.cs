using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignments1
{
    internal class Exercise_2
    {
        public void Convertion()
        {
            Console.WriteLine("Enter Distance in KMs: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Convert into Meters: " + (k * 1000));
        }
    }
}
