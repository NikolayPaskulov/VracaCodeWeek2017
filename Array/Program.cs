using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            //                 0    1    2     3       4          5
            // Array array = ["a", "z", "g", "Ivan", "Vraca", "Software"];

            string[] array = new string[6] { "a", "z", "g", "Ivan", "Vraca", "Software" };
            int[] intArray = new int[2] { 2, 200 }; 
            string firstElementOfArray = array[0];
            Console.WriteLine(array[0]);
            array[0] = "Gosho";
            Console.WriteLine(array[0]);
            Console.WriteLine(firstElementOfArray);

            Console.WriteLine(intArray[0] + intArray[1]);

            string a = "Vraca";
            int indexOfA = a.IndexOf('a');
            Console.WriteLine(indexOfA);
            string aObject = new string('a', 5);
            Console.WriteLine(aObject);

            List<int> intList = new List<int>();
            Console.WriteLine(intList);
        }
    }
}
