using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass3.Q2
{
    class Program
    {
        public static void Main(String[] arg)
        {
            MyStack S = new MyStack(5);
            MyStack C = (MyStack)S.Clone();

            C.push(10);
            C.push(20);
            C.push(30);
            C.push(40);
            C.push(50);

            Console.WriteLine("Items are : ");
            C.printStack();
            C.pop();
            C.pop();
            C.pop();

            Console.WriteLine("Items are : ");
            C.printStack();
        }
    }
}
