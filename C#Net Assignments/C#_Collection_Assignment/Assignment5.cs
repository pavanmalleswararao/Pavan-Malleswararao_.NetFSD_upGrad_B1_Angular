using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C__Collection_Assignment_Hospital_Patient_Queue
{
    internal class Patient
    {
        public int Id;
        public string Name;
        public string Disease;
    }
    class Program
    {
        static void Main()
        {
            Queue<Patient> queue=new Queue<Patient>();

            queue.Enqueue(new Patient { Id = 1, Name = "A", Disease = "Fever" });
            queue.Enqueue(new Patient { Id = 2, Name = "B", Disease = "Cold" });
            queue.Enqueue(new Patient { Id = 3, Name = "C", Disease = "Headache" });
            queue.Enqueue(new Patient { Id = 4, Name = "D", Disease = "Cough" });
            queue.Enqueue(new Patient { Id = 5, Name = "E", Disease = "Injury" });

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("Next Patient:");
            Console.WriteLine(queue.Peek().Name);

            Console.WriteLine("\nRemaing Patients:");
            foreach(var p in queue)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
