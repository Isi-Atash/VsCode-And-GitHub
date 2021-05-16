using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Hello");
            string ad="hello";
            // string number="123";
            int a =Convert.ToInt32(ad);
            int b = int.Parse(ad);
            // int c = (int)ad;

            Console.WriteLine($"{a}{b}");
        }
    }
}
