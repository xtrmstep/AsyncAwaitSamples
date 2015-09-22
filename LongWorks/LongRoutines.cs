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
        public static int LongJob(int arg)
        {
            Thread.Sleep(arg);
            Console.WriteLine("Job done " + arg);

            return arg;
        }

        public static int LongJobWithCallback(int arg, Action action)
        {
            Thread.Sleep(arg*1000);
            Console.WriteLine("Job done " + arg);
            if (action != null)
                action();

            return arg;
        }
    }
}
