using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass1
{
    class Q3
    {
        public static void Main(string[] args)
        {
            Q3 v = new Q3();
            int result = v.add(1, 2, 3, 7, 89);
            Console.WriteLine("Addition of all numbers is:" + result);
        }

        public int add(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            return result;
        }
    }
}
