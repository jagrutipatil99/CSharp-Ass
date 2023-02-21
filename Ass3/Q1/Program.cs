﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass3.Q1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Emloyee details:");
            Console.WriteLine("Emp No:");
            int eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emp Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Salary:");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Position:");
            Console.WriteLine("1.Employee");
            Console.WriteLine("2.Manager");
            Console.WriteLine("3.Marketing Executive");

            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Employee emp = new Employee();
                    emp.Accept(eno, name, sal);
                    emp.CalculateGross();
                    emp.CalculateSalary();
                    emp.display();
                    break;

                case 2:
                    Manager mp = new Manager();
                    mp.Accept(eno, name, sal);
                    mp.CalculateGross();
                    mp.CalculateSalary();
                    mp.display();
                    break;

                case 3:
                    MarketingExecutive me = new MarketingExecutive();
                    me.Accept(eno, name, sal);
                    me.CalculateGross();
                    me.CalculateSalary();
                    me.display();
                    break;
            }


        }
    }
}
