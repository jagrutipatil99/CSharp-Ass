using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass1
{
    class Q4
    {
        public int swap(int num1, int num2)
        {
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("Number 1=" + num1);
            Console.WriteLine("Number 2=" + num2);
            return 0;
        }

        public static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the Numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping:");
            Console.WriteLine("Number 1=" + num1);
            Console.WriteLine("Number 2=" + num2);
            server s = new server();
            s.swap(num1, num2);
        }
    }
}
