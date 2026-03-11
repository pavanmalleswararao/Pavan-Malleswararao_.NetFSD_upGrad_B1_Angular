using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignments1
{
    internal class Exercise_8
    {
        public void VowelorConsonents()
        {
            Console.WriteLine("Enter a Character:");
            Char c = Convert.ToChar(Console.ReadLine());
            if (c=='a' || c=='e' || c=='i' || c=='o' || c== 'u'){
                Console.WriteLine(c+"is a Vowels");
            }
            else
            {
                Console.WriteLine(c + " is a Consonent");
            }
        }
    }
}
