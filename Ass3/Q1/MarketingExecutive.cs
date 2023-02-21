using System;


namespace CSharpAss_All.Ass3.Q1
{
    class MarketingExecutive : Employee
    {
        double Km_Travel;
        double Tel_A;
        double Tour_A;
        double gs;

        public new void CalculateGross()
        {
            Console.WriteLine("Enter Travel distance in KM:");
            Km_Travel = Convert.ToInt32(Console.ReadLine()); ;

            Tel_A = 1000;

            Tour_A = Km_Travel * 5;

            base.CalculateGross();
            gs = GROSSSALARY;

            GROSSSALARY = GROSSSALARY + Tel_A + Tour_A;

        }
        public override void CalculateSalary()
        {

            PF1 = gs / 10;

            TDS1 = gs / 18;

            NETSALARY = gs - (PF1 + TDS1);

        }
        
    }
}
