using System;

namespace NewLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine($"NewLine: {Environment.NewLine}  first line{Environment.NewLine}  second line");
        }
    }
}
