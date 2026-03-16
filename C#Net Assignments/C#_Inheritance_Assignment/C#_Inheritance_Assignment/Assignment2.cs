using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment_Banking
{
    class Account
    {
        public long AccountNumber {  get; set; }
        protected double Balance {  get; set; }

        public Account(double balance)
        {
            Balance = balance;
        }
        public void CalculateInterest()
        {
            double interest = Balance*0.02;
            Console.WriteLine("Base Class Calculate Interest: "+interest);
        }
    }
    class SavingsAccount:Account
    {
        public SavingsAccount(double balance):base(balance)
        {

        }
        public new void CalculateInterest()
        {
            double interest = Balance * 0.05;
            Console.WriteLine("Savings Account Interest: " + interest);
        }
    }

    class CurrentAccount : Account
    {
        public CurrentAccount(double balance) : base(balance) { }
        
        public new void CalculateInterest() {
            double interest = Balance * 0.08;
            Console.WriteLine("Current Account Interest: " + interest);
        }
    }
}
