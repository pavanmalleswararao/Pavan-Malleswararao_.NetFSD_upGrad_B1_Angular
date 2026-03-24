using System;
using System.Collections.Generic;
using System.Text;

namespace C__MultiThreading
{
    internal class Assignment1
    {
        static int[] partialSums = new int[5];

        static void ProcessNumbers(object obj)
        {
            int threadIndex = (int)obj;
            int start = threadIndex * 10 + 1;
            int end = start + 9;

            int sum = 0;

            Console.WriteLine($"Thread {threadIndex + 1} processing:");

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine($"\nThread {threadIndex + 1} Sum: {sum}\n");

            partialSums[threadIndex] = sum;
        }

        static void Main()
        {
            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(ProcessNumbers);
                threads[i].Start(i);
            }

            // Wait for all threads
            foreach (Thread t in threads)
            {
                t.Join();
            }

            int finalSum = 0;
            foreach (int sum in partialSums)
            {
                finalSum += sum;
            }

            Console.WriteLine("Final Sum: " + finalSum);
        }
    }
}
