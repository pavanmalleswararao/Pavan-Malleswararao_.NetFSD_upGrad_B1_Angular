using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collection_Assignment_Undo_Feature
{
    class Program
    {
        static void Main()
        {
            Stack<string> actions = new Stack<string>();
            actions.Push("Type A");
            actions.Push("Type B");
            actions.Push("Type C");
            actions.Push("Type D");

            Console.WriteLine("Undo 3 actions:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(actions.Pop());
            }

            Console.WriteLine("\nTop Action:");
            Console.WriteLine(actions.Peek());

            Stack<string> redo= new Stack<string>();
            redo.Push("Type X");

            Console.WriteLine("\nRedo Action:");
            Console.WriteLine(redo.Pop());
        }
    }
}
