using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;

            int sum = a + b;
            Console.WriteLine("a + b");
            Console.WriteLine(sum);

            int r = a - b;
            Console.WriteLine("a - b");
            Console.WriteLine(r);

            int f = a * b;
            Console.WriteLine("a * b");
            Console.WriteLine(f);

            int y = a / b;
            Console.WriteLine("a / b");
            Console.WriteLine(y);

            string hello = "Hello";
            string world = "world";
            Console.WriteLine(hello + " " + world);
        }
    }
}
