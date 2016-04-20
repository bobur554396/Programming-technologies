using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("ABC",123);
            s.Age = 777;

            Console.WriteLine(s.Age);

            Console.ReadKey();
        }
    }
}
