using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            string input = Console.ReadLine();
            for(int i = 0;i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
