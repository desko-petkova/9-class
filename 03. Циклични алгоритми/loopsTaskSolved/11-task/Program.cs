using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            string input = Console.ReadLine();
            int Max = int.MinValue;
            while(input != "Stop")
            {
                int a = int.Parse(input);
                if(Max < a)
                {
                    Max = a;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(Max);
        }
    }
}
