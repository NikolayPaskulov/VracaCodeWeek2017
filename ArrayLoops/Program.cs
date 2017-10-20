using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            string searchString = Console.ReadLine();
            char searchChar = searchString[0];

            char[] charArray = inputWord.ToCharArray();

            for(int i = 0; i < inputWord.Length; i++)
            {
                char c = charArray[i];
                if(c == searchChar)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine();
        }
    }
}
