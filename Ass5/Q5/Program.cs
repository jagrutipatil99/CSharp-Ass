using System;
using System.Collections.Generic;


namespace CSharpAss_All.Ass5.Q5
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> listEmployees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("1.Enter Employee Details");

                Console.WriteLine("2.Display");

                Console.WriteLine("3.Total Employee Count");

                Console.WriteLine("4.Search Employee by name");

                Console.WriteLine("Eneter your Choice :");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        {

                            Console.WriteLine("Enter The No. Employees details you want to enter:");
                            int ch = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < ch; i++)
                            {

                                Console.WriteLine("$Enter Employee " + i + " Details:");
                                Console.WriteLine("Enter Emp ID:");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Emp name:");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter Emp department:");
                                string department = Console.ReadLine();
                                Console.WriteLine("Enter Emp joining date:");
                                string jdate = Console.ReadLine();
                                Console.WriteLine("Enter Emp salary:");
                                int salary = Convert.ToInt32(Console.ReadLine());

                                Employee emp1 = new Employee() { ID = id, Name = name, Department = department, Joining_Date = jdate, Salary = salary };
                                listEmployees.Add(emp1);
                            }
                        }
                        break;


                    case 2:
                        {
                            Console.WriteLine("\n All Details of Employees:");
                            foreach (Employee employee in listEmployees)
                            {
                                Console.WriteLine("Employee Detail:");


                                Console.WriteLine($"\nID = {employee.ID}, \nName = {employee.Name}, " +
                                    $"\nDepartment = {employee.Department},\nJoining_Date={employee.Joining_Date}, " +
                                    $"\nSalary = {employee.Salary}");
                            }
                        }
                        break;
                    case 3:
                        {

                            Console.WriteLine($"\n\nTotal Employee Count : {listEmployees.Count}");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\nEnter Employee Name:");
                            string nm = Console.ReadLine();
                            List<Employee> findEmp = listEmployees.FindAll(employee => employee.Name == nm);
                            foreach (Employee employee in findEmp)
                            {
                                Console.WriteLine($"\nID = {employee.ID}, \nName = {employee.Name}, " +
                                    $"\nDepartment = {employee.Department},\nJoining_Date={employee.Joining_Date}, " +
                                    $"\nSalary = {employee.Salary}");
                            }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Wrong Choice");
                        }
                        break;

                }
            }
        }
    }
}
