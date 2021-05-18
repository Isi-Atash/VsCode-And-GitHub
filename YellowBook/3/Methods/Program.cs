using System;
using static System.Console;

namespace Methods
{
    class Program
    {
<<<<<<< HEAD
=======
        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;

>>>>>>> TryClasses
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
<<<<<<< HEAD
=======
            // DoIt();
            // Stupid(9);
            // StupidReturnAdd(9);

            // double windowWidth = ReadValue(MIN_WIDTH, MAX_WIDTH, "Enter width of Window");
            // WriteLine($"Width is {windowWidth}");

            // double age = ReadValue(0, 99);
            // WriteLine($"Age is {age}");

            // int test = 19;
            // AddOne(test);
            
            // //This Ref method, brcause of ref parameter, will change the value of test var outside of method too.
            // AddOneRefParam(ref test);
            // WriteLine(test);

            // string name1;
            // int age2;
            ReadPerson(out string name, out int age);
            WriteLine($"{name} is {age} years old");

            CommonClass commonClass = new CommonClass();
            commonClass.ReadMe();

            // CommonClass.ReadMe();
            // MethodLibraries alma=new MethodLibraries();
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

        static void AddOne(int i)
        {
            i++;
            WriteLine($"i is {i}");
        }

        static void AddOneRefParam(ref int i)
        {
            i++;
            WriteLine($"i is {i}");
>>>>>>> parent of 6db4f41 (At last, i was able to Reference)
        }
    }
}
