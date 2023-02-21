﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass6.Q1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee no : ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Name : ");
            string empName = Console.ReadLine();
            Console.WriteLine("Employee Salary : ");
            int empSal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Km you travel : ");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            Employee emp = new Employee(empId, empName, empSal);
            emp.info();

            Manager mn = new Manager(empId, empName, empSal);
            mn.CalGrossSal();
            mn.CalculateSal();


            MarketingExecutive me = new MarketingExecutive(empId, empName, empSal, km);

            me.CalGrossSal();
            me.CalculateSal();


            ManagerInfo del = new ManagerInfo(mn.info);
            del += me.info;
            del();

        }
    }
}
