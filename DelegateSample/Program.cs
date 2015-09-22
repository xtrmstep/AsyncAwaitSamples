using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LongWorks;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is started.");
            var work = new Work(LongRoutines.LongJob);
            work.BeginInvoke(3000, null, null);
            Console.WriteLine("Waiting...");
            Console.ReadKey();
        }

        delegate void Work(int arg);
    }
}
