using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thread_demo
{
    class Worker
    {
        public bool shoulWork = true;

        public  void work() {
            int i = 0;
            while (shoulWork) {
                Console.WriteLine("Class worker working... " + i++);
            }
        }

        public void Stop() {
            this.shoulWork = false;
        }
    }
}
