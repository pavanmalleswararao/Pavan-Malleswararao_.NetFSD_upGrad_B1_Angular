using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignments1
{
    internal class Exercise_6
    {
        public void Rectangle()
        {
            Console.WriteLine("Enter Length:");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            int w = Convert.ToInt32(Console.ReadLine());
            int area=l*w;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        public void Square()
        {
            Console.WriteLine("Enter length");
            int a = Convert.ToInt32(Console.ReadLine());
            int area = a * a;
            Console.WriteLine("Area of Square"+ area);
        }
        public void Calculate()
        {
            Console.WriteLine("Enter Rectangle or Square:");
            string value = Console.ReadLine();
            if (value.ToLower() == "rectangle")
            {
                Rectangle();
            }
            else
            {
                Square();
            }
        }
    }
}
