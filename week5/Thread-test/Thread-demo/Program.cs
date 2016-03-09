using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The main thread stared");


            Worker w = new Worker();

            Thread t1 = new Thread(w.work);
            t1.Start();
            Thread.Sleep(1000);

            w.Stop();

            Console.WriteLine("The main thread finished");

            Console.ReadKey();
        }

    }
}
