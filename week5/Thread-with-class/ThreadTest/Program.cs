using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Thread t1 = new Thread(f);
            Thread t2 = new Thread(f);
            t1.Name = "Thread 1";
            t2.Name = "Thread 2";
            t1.Start();
            t1.Join();
            t2.Start();*/

            Thread[] arr = new Thread[5];
            for (int i = 1; i <= 4; i++) {
                arr[i] = new Thread(new ThreadStart(f));
                arr[i].Name = "Thread " + i;
                arr[i].Start();
                //arr[i].Join();
            }

            Console.ReadKey();
        }
        private static void f()
        {
            object oLock = new object();
            lock (oLock) {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " prints: " + i);
                }
                Thread.Sleep(1000);            
            }
        }
    }
}
