using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LongWorks;

namespace AsyncAwaitSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is started.");
            var thread = new Thread(() => LongRoutines.LongJob(3000));
            thread.Start();
            Console.WriteLine("Waiting...");
            Console.ReadKey();
        }
    }
}
