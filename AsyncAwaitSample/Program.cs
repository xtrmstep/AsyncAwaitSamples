using System;
using System.Threading.Tasks;
using LongWorks;

namespace AsyncAwaitDifference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Program is started.");

            Task.Run(() => LongRoutines.LongJob(1));
            Task.Run(() => LongRoutines.LongJob(2));
            Task.Run(() => LongRoutines.LongJob(3));

            Console.WriteLine("Waiting 1...");

            DoAsyncWork();

            Console.WriteLine("Waiting 2...");
            Console.WriteLine("Press a key");
            Console.ReadKey();
        }

        private static async Task DoAsyncWork()
        {
            Console.WriteLine("11");
            var t = Task.Factory.StartNew(() => LongRoutines.LongJob(4000));
            //await Task.Factory.StartNew(() => LongRoutines.LongJob(4000));

            Console.WriteLine("22");
            await Task.Factory.StartNew(() => LongRoutines.LongJob(5));

            Console.WriteLine("33");
            await t;
            await Task.Factory.StartNew(() => LongRoutines.LongJob(6));

            Console.WriteLine("44");
        }
    }
}