using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 3;

            // 0 + 1 ... + 1 ... +1 < end
            int sum = 0;
            for(int j = start; j <= end; j += 1)
            {
                sum = sum + j;
            }

            Console.WriteLine(sum);

            string text = "";
            while (!text.Contains("a"))
            {
                for(int i = 0; i < 256; i++)
                {
                    char c = (char)i;
                    text = text + c;
                    Console.WriteLine("Number: " + i + ";Symbol: " + c);
                }
            }
        }
    }
}
