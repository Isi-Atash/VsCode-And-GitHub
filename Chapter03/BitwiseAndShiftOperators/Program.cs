using System;
using static System.Console;
using System.Diagnostics;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Stopwatch w= new Stopwatch();
            w.Start();
            double d=0;
            for(int i=0; i<10000000;i++)
            {
                try
                {
                    d = Math.Sin(1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            w.Stop();
            WriteLine(w.Elapsed);

            w.Reset();
        w.Start();

        for (int i = 0; i < 10000000; i++)
        {
            d = Math.Sin(1);
        }

        w.Stop();
        Console.WriteLine(w.Elapsed);
        }
    }
}
