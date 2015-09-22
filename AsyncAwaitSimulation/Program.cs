using System;
using System.Threading;
using System.Threading.Tasks;
using LongWorks;

namespace AsyncAwaitSimulation
{
    internal class Program
    {
private static void Main(string[] args)
{
    Console.WriteLine("Program is started.");

    Task.Run(() => LongRoutines.LongJob(3000));
    Task.Run(() => LongRoutines.LongJob(3000));
    Task.Run(() => LongRoutines.LongJob(3000));

    Console.WriteLine("Waiting 1...");

    Task.Factory.StartNew(() => LongRoutines.LongJob(3000))
        .ContinueWith(t => LongRoutines.LongJob(3000))
        .ContinueWith(t => LongRoutines.LongJob(3000))
        .Wait();

    Console.WriteLine("Waiting 2...");
    Console.WriteLine("Press a key");
    Console.ReadKey();
}
    }
}