using System;

namespace CSharpAss_All.Ass1
{
    class Q1
    {
        public static void Main(String[] args)
        {
            int Num1, Num2, result, ch;
            Console.WriteLine("Please Enter 2 numbers");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Num2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Enter your Choice:");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Exit");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        result = Num1 + Num2;
                        Console.WriteLine("Addition of " + Num1 + " And " + Num2 + " is " + result);
                        break;
                    case 2:
                        result = Num1 - Num2;
                        Console.WriteLine("Subtraction of " + Num1 + " And " + Num2 + " is " + result);
                        break;
                    case 3:
                        result = Num1 * Num2;
                        Console.WriteLine("Multiplication of " + Num1 + " And " + Num2 + " is " + result);
                        break;
                    case 4:
                        result = Num1 / Num2;
                        Console.WriteLine("Division of " + Num1 + " And " + Num2 + " is " + result);
                        break;
                }
            } while (ch != 5);
        }
    }
}
