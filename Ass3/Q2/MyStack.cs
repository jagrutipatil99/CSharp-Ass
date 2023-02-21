using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass3.Q2
{
    class MyStack : ICloneable
    {

        private int[] data;
        private int top;
        private int max;
        public MyStack(int size)
        {
            data = new int[size];
            top = -1;
            max = size;
        }

        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                data[++top] = item;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + data[top]);
                return data[top--];
            }
        }

        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + data[i]);
                }
            }
        }
        public object Clone()
        {
            return this;
        }
    }
}
