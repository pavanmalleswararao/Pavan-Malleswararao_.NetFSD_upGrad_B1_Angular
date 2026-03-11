using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignments1
{
    internal class Exercise_3
    {
        public void SumandAvarage()
        {
            int num1, num2, num3, num4, num5, sum = 0, avarage = 0;
            Console.WriteLine("Enter 5 numbers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine(sum);
            avarage = sum/5;
            Console.WriteLine(avarage);
        }
    }
}
