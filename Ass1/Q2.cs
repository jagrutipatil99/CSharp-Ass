using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass1
{
    class Q2
    {
        public static void Main(string[] args)
        {
            int[] Num = new int[5];
            int temp = 0;
            Console.WriteLine("Please Enter average marks of five students:");
            for (int i = 0; i < 5; i++)
            {
                Num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("average marks of five students:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Num[i]);
            }
            temp = Num[1];
            for (int j = 0; j < 5; j++)
                if (temp < Num[j])
                {
                    temp = Num[j];
                }
            Console.WriteLine("Highest Marks Obtained are:" + temp);
        }
    }
}
