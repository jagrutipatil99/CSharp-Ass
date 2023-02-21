using System;
using System.IO;

namespace CSharpAss_All.Ass7
{
    class Q2
    {
        static void Main(string[] args)
        {
            // create directory
            String path = @"C:\Users\JVILASPA\source\repos\CSharpAss_All\Ass7\";

            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                Console.WriteLine("Directory has been created");
            }
            Console.WriteLine("Directory Path =" + fl.FullName);

            // Get the directory name
            Console.WriteLine("Directory Name=" + fl.Name);

            // Get the parent directory
            Console.WriteLine("Parent Directory=" + fl.Parent);


            string[] directory = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            //return name of sub directory



            string[] file = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            //return name of sub file
            Console.WriteLine("Directory Details (sub-directories)----");
            foreach (string diNext in directory)
            {
                var dirInfo = new DirectoryInfo(diNext);
                Console.WriteLine(dirInfo.FullName);
            }
            Console.WriteLine("File Details----");
            foreach (string fiNext in file)
            {
                var fileInfo = new FileInfo(fiNext);
                Console.WriteLine(fileInfo.FullName);


            }



        }
    }
}
