using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            Console.WriteLine($"Enter {n} numbers:");
            Console.WriteLine("-------------");
            for(int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if(a > max)
                {
                    max = a;
                }
                if(a < min)
                {
                    min = a;
                }

            }
            Console.WriteLine("-------------");
            Console.WriteLine($"Max numbre: {max}");
            Console.WriteLine($"Min numbre: {min}");

        }
    }
}
