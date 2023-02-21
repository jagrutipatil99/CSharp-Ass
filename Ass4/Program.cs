using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass4
{
    class Program
    {
        static void Main()
        {
            MyStack C = new MyStack(5);
            try
            {
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
                C.pop();
                C.pop();
                C.pop();

                Console.WriteLine("Items are : ");
                C.printStack();
            }
            catch (StackException e)
            {
                Console.WriteLine("StackException: {0}", e.Message);
            }
        }
    }
}
