using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass5
{
    class Q1
    {
        public static void Main(string[] args)
        {
            int[] array1 = { 23, 56, 2, 89, 45, 14, 6 };
            string[] array2 = { "Priya", "Ajay", "Isha", "Kiran" };
            string[] array3 = { "", "", "", "", "", "Vikas", "Trisha" };
            Console.WriteLine("Original Elements in Array1 :");
            foreach (int var in array1)
            {
                Console.Write(var + " ");
            }
            Console.WriteLine("\n\nOriginal Elements in Array2 :");
            foreach (string i in array2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\nSorted Elements in Array1 :\n");
            Array.Sort(array1);
            foreach (int var in array1)
            {
                Console.Write(var + " ");
            }
            Console.WriteLine("\n\nSorted Elements in Array2 :");
            Array.Sort(array2);
            foreach (string i in array2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\nReversed Elements in Array1 :");
            Array.Reverse(array1);
            foreach (int var in array1)
            {
                Console.Write(var + " ");
            }
            Console.WriteLine("\n\nReversed Elements in Array2 :");
            Array.Reverse(array2);
            foreach (string i in array2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\nCleared Elements in Array1 :");
            Array.Clear(array1, 0, 7);
            foreach (int var in array1)
            {
                Console.Write(var + " ");
            }
            Console.WriteLine("\n\nCopied Elements in Array3 from array2 :");
            Array.Copy(array2, array3, 4);
            foreach (string var in array3)
            {
                Console.Write(var + " ");
            }
        }

    }
}
