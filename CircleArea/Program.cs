using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string rAsString = Console.ReadLine();

            double r = double.Parse(rAsString);

            // Calculate circle area
            double area = Math.PI * r * r;

            area = Math.Round(area, 4);

            Console.WriteLine(area);
        }
    }
}
