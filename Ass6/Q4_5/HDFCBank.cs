using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass6.Q4_5
{
    class HDFCBank : Account
    {
        public HDFCBank(double no, string name, double bal) : base(no, name, bal)
        {

        }
        public bool ZeroBalance()
        {
            if (acc_balance <= 0)
            {
                Console.WriteLine("Transaction cannot be continued...Balance is 0");
                return true;
            }
            else
                return false;
        }
        public bool UnderBalance(double amount)
        {
            if (acc_balance <= 1000)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of Rs.-1000");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
