using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass4
{
    class MyStack
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
                throw (new StackException("Stack OverFlow"));
                //  return;
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
                throw (new StackException("Stack UnderFlow"));
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
    }
}
