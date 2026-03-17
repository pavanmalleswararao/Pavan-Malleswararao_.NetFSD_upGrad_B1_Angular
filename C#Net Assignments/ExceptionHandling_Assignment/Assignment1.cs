using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ExceptionHandling_Assignment
{
    class CheckBalanceException : Exception
    {
        public CheckBalanceException(string messsage):base(messsage) { }
    }
    internal class BankAccount
    {
        public long AccountNumber;
        public string Name;
        public static double Balance;
        
        public BankAccount(long accNum,string name,double balance)
        {
            AccountNumber = accNum;
            Name= name;
            Balance = balance;
        }

        public void Transaction(char type, double amount)
        {
            if (type == 'd')
            {
                Balance += amount;
                Console.WriteLine("Amount Deposited Successfully");
            }
            else if (type == 'c')
            {
                if (Balance - amount < 500)
                {
                    throw new CheckBalanceException("Minimum balance of 500 must maintained!");
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine("Amount Withdraw Successfully");
                }
            }
        }
        public void Details()
        {
            Console.WriteLine($"Account No: {AccountNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
