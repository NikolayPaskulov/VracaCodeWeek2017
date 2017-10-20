using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputAndOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();

            int a = int.Parse(firstLine);
            int b = int.Parse(secondLine);

            int c = a * b;

            Console.Write("Sum: ");
            Console.Write(c);
            
            Console.WriteLine();
        }
    }
}
