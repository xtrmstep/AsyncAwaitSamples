using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LongWorks;

namespace TplSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is started.");

            Parallel.Invoke(() => LongRoutines.LongJob(3000));
            Task.Run(() => LongRoutines.LongJob(3000));
            new TaskFactory().StartNew(() => LongRoutines.LongJob(3000));

            Console.WriteLine("Waiting...");
            Console.ReadKey();
        }
    }
}
