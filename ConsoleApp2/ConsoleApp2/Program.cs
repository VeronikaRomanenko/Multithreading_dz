using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadstart = new ThreadStart(Method);
            Thread thread = new Thread(threadstart);
            Thread.Sleep(new Random().Next(1000, 5000));

            Console.WriteLine("!!!!!!!");

            System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
            swatch.Start();

            thread.Start();
            thread.Join();

            swatch.Stop();
            Console.WriteLine(swatch.Elapsed.Milliseconds);
        }

        static void Method()
        {
            Console.ReadKey();
        }
    }
}