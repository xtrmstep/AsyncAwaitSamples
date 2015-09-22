using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LongWorks;

namespace ThreadPoolSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is started.");
            ThreadPool.QueueUserWorkItem(new WaitCallback(WorkItem));
            Console.WriteLine("Waiting...");
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }

        static void WorkItem(object state)
        {
            LongRoutines.LongJob(3000);
        }
    }
}
