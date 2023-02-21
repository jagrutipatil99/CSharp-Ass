using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass3.Q1
{
    class Manager : Employee
    {
        double Petrol_A;

        double Food_A;

        double Other_A;

        double gs;

        public new void CalculateGross()
        {
            Petrol_A = SALARY / 8;
            Food_A = SALARY / 13;
            Other_A = SALARY / 3;

            base.CalculateGross();
            gs = GROSSSALARY;

            GROSSSALARY = GROSSSALARY + Petrol_A + Food_A + Other_A;

        }
        public override void CalculateSalary()
        {

            PF1 = gs / 10;

            TDS1 = gs / 18;

            NETSALARY = gs - (PF1 + TDS1);



        }
        

    }
}
