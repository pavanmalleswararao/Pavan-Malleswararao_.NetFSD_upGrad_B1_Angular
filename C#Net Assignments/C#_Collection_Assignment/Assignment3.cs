using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collection_Assignment_Online_Event_Registration
{
    class Program
    {
        static void Main()
        {
            HashSet<string> emails = new HashSet<string>()
            {
                 "a@gmail.com", "b@gmail.com", "c@gmail.com",
                "a@gmail.com", "d@gmail.com", "e@gmail.com",
                "b@gmail.com", "f@gmail.com", "g@gmail.com", "h@gmail.com"
            };

            Console.WriteLine("\nUnique EMails:");
            foreach (var e in emails)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nCheck Emails:");
            Console.WriteLine(emails.Contains("a@gmail.com"));

            emails.Remove("b@gmail.com");

            HashSet<string> events = new HashSet<string>()
            {
                "a@gmail.com", "x@gmail.com", "y@gmail.com"
            };

            events.IntersectWith(emails);

            Console.WriteLine("\nCommon Participants:");
            foreach(var e in events)
                Console.WriteLine(e);
        }
    }
}
