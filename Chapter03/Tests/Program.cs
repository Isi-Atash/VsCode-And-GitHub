using System;
using static System.Console;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteLine(RepeatStr(9, "alma"));
        }
        public static string RepeatStr(int n, string s)
        {
            string word = s;
            for (int i = 0; i < n; i++)
            {
                word += s;
            }
            return word;
        }
    }
}
