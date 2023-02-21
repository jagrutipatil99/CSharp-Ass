using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass6.Q4_5
{
    class ICICIBank : Account
    {
        public ICICIBank(double no, string name, double bal) : base(no, name, bal)
        {


        }
        public bool ZeroBalance()
        {
            if (acc_balance <= 0)
            {
                Console.WriteLine("Transaction cannot be continued as balance is insufficient/zero in Account");
                return true;
            }
            else
                return false;
        }
        public bool UnderBalance(double amount)
        {
            if (acc_balance <= 1000)
            {
                Console.WriteLine("Transaction cannot be continued as balance is insufficient/zero in Account");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
