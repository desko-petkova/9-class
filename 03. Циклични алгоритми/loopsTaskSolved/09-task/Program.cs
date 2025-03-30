using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while(sum < num)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
            }
            Console.Write($"={sum}");
        }
    }
}
