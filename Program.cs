using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        static void doApp()
        {

            string dir = Directory.GetCurrentDirectory();
            string filename = @"C:\Users\SAI PAVAN KUMAR\source\repos\WorkingWithFiles2\WorkingWithFiles2\Data.txt";

            if (File.Exists(filename))

                Console.WriteLine(filename + " exists");
            else
                Console.WriteLine(filename + " does not exist");

            using (StreamWriter wrt = File.CreateText(filename))
            {
                Console.WriteLine("First line: SaiPavan");
                Console.WriteLine("Second  line: Pavan");
                Console.WriteLine("Third is line: Kalyan");
                Console.WriteLine("Fourth is line: SaiPavanKalyan");
            }
            Console.WriteLine(filename + " created");

            string[] lines = File.ReadAllLines(filename);
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }

            string text = File.ReadAllText(filename);
            Console.WriteLine(text);

            File.Delete(filename);
            Console.WriteLine(filename + " was deleted");
        }
    }
}
