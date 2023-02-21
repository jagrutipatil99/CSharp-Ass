using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass6.Q4_5
{
    class Program
    {
        static void Main(string[] args)
        {

            HDFCBank hdfc_cust = new HDFCBank(9083456, "Devashri More", 500);

            hdfc_cust.Deposit(4000);

            hdfc_cust.Withdraw(400, hdfc_cust.UnderBalance, hdfc_cust.ZeroBalance);

            Console.WriteLine("-------------------------------------------------------");

            ICICIBank icici_cust = new ICICIBank(7865345, "John Conner", 500);

            icici_cust.Deposit(400);

            icici_cust.Withdraw(9000, icici_cust.UnderBalance, icici_cust.ZeroBalance);
        }
    }
}
