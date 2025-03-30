using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            string input = Console.ReadLine();
            int Min = int.MaxValue;
            while (input != "Stop")
            {
                int a = int.Parse(input);
                if (Min > a)
                {
                    Min = a;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(Min);
        }
    }
}
