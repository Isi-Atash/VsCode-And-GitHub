using System;
using static System.Console;

namespace Methods
{
    class Program
    {
        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            DoIt();
            Stupid(9);
            StupidReturnAdd(9);

            double windowWidth = ReadValue(MIN_WIDTH, MAX_WIDTH, "Enter width of Window");
            WriteLine($"Width is {windowWidth}");

            double age = ReadValue(0, 99);
            WriteLine($"Age is {age}");
        }

        static void DoIt()
        {
            WriteLine("Hello mtfk)");
        }

        static void Stupid(int age)
        {
            WriteLine($"Stupid is {age}");
        }

        static int StupidReturnAdd(int age)
        {
            age++;
            WriteLine($"Stupid is {age} after 1 year");
            return age;
        }

        static double ReadValue(double low, double high, string prompt = "Salam")
        {
            double result = 0.0;

            do
            {
                WriteLine($"{prompt} between {low} and {high}");
                string resultString = ReadLine();
                bool isResult = double.TryParse(resultString, out result);
                result = double.Parse(resultString);
            } while ((result < low) || (result > high));

            return result;
        }

        static void MyMethod(string country = "Norway")
        {
            WriteLine(country);
        }
    }
}
