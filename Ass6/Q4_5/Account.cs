using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass6.Q4_5
{
    public delegate bool UnderBalance(double amount);
    public delegate bool ZeroBalance();
    class Account
    {

        //public event del MyEvent;

        public double acc_number;
        public string cust_number;
        public double acc_balance;
        public double amount;

        public Account(double no, string name, double bal)
        {
            acc_number = no;
            cust_number = name;
            acc_balance = bal;

            Display();
        }

        public void Deposit(double amount)
        {
            acc_balance = acc_balance + amount;
            Console.WriteLine("Deoposited amount: " + amount);
            Console.WriteLine("After Deposition, Balnce is: " + acc_balance);
        }

        public void Withdraw(double amount, UnderBalance uBalance, ZeroBalance zBalance)
        {
            if (!zBalance())
            {
                if (!uBalance(amount))
                {
                    acc_balance = acc_balance - amount;
                    Console.WriteLine("Withdraw amount: " + amount);
                    Console.WriteLine("After Withdrawal, Balance is: " + acc_balance);
                }
            }

        }

        public void Display()
        {
            Console.WriteLine(" Customer Name is: " + cust_number + "\n Account Number is:"
                + acc_number + "\n Balance is: " + acc_balance);
            Console.WriteLine("----------------------------------------------------");

        }


    }
}
