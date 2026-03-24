using System;
using System.Collections.Generic;
using System.Text;

namespace C__MultiThreading_Bank
{
    internal class BankAccount
    {
        private int Balance = 1000;
        private readonly object lockObj = new object();

        public void Withdraw(int amount)
        {
            lock (lockObj)
            {
                if (Balance >= amount)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " is withdrawing " + amount);
                    Balance -= amount;
                    Console.WriteLine("Remaining Balance: " + Balance);
                }
                else
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " - Insufficient balance!");
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            Thread t1 = new Thread(() => account.Withdraw(700)) { Name = "User1" };
            Thread t2 = new Thread(() => account.Withdraw(500)) { Name = "User2" };
            Thread t3 = new Thread(() => account.Withdraw(300)) { Name = "User3" };

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
