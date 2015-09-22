using System;
using System.Threading.Tasks;

namespace ThreadExceptionSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SomeMethod().Wait();
        }

        public static async Task SomeMethod()
        {
            try
            {
                await AsyncWork();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception is handled " + e);
            }
        }

        public static Task AsyncWork()
        {
            return Task.Factory.StartNew(() =>
            {
                throw new Exception();
            });
        }
    }
}