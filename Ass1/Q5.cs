using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass1
{
    class Q5
    {
        const double pie = 3.14F;
        public double area(double r)
        {
            double a = pie * (r * r);
            return a;
        }
        public double circum(double r)
        {
            double c = 2 * pie * r;
            return c;
        }

        public static void Main(string[] args)
        {
            Q5 s = new Q5();
            Console.WriteLine("Enter the radius of circle");
            double r = Convert.ToDouble(Console.ReadLine());
            double a1 = s.area(r);
            Console.WriteLine("Area of Circle is:" + a1);
            double c1 = s.circum(r);
            Console.WriteLine("Circumference of Circle is:" + c1);
        }
    }
}
