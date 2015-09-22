using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LongWorks
{
    public class LongRoutines
    {
        public static void LongJob(int arg)
        {
            Thread.Sleep(arg);
            Console.WriteLine("Job done");
        }
    }
}
