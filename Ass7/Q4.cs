using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpAss_All.Ass7
{
    class Q4
    {
        [Serializable]
        class Program
        {

            public int ID;
            public string Name;
            public double Salary;
            static void Main(string[] args)
            {
                Program obj = new Program();

                Console.WriteLine("Enter the number of Employees you want to Store:");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Enter Manager ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    obj.ID = id;
                    Console.WriteLine("Enter Manager Name:");
                    string nm = Console.ReadLine();
                    obj.Name = nm;
                    Console.WriteLine("Enter Manager Salary:");
                    double sal = Convert.ToDouble(Console.ReadLine());
                    obj.Salary = sal;

                }

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"C:\Users\JVILASPA\source\repos\CSharpAss_All\Ass7\Assign7_Q4.txt", FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, obj);
                stream.Close();

                stream = new FileStream(@"C:\Users\JVILASPA\source\repos\CSharpAss_All\Ass7\Assign7_Q4.txt", FileMode.Open, FileAccess.Read);
                Program objnew = (Program)formatter.Deserialize(stream);

                Console.WriteLine(objnew.ID);
                Console.WriteLine(objnew.Name);
                Console.WriteLine(objnew.Salary);

                Console.ReadKey();
            }

        }
    }
}
