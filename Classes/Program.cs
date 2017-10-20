using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            Person[] p = new Person[300];

            for (int i = 0; i < length; i++)
            {

            }

            Person ivan = new Person("Ivan Ivanov");
            Person georgi = new Person("Georgi Georgiev");

            Console.WriteLine(ivan.Name);
            Console.WriteLine(georgi.Name);
        }
    }

    class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
