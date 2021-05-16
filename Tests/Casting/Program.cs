using System;
using static System.Console;

namespace Casting
{
    class Program
    {
       static void Main()
        {
            CosSin();
        }
        static void CosSin()
        {
            WriteLine("Hello");
            int x = 1, y = 2, z = 3;
            float yy = y;
            // float r = x;
            float fraction = (float)x / (float)y / (float)z;
            WriteLine(fraction);
            WriteLine(yy.GetType());
            // WriteLine(typeof(yy))

            double maxDouble = Double.MaxValue;
            float isFloat = (float)maxDouble;
            float maxFloat = float.MaxValue;
            double isDouble = (double)maxFloat;
            float maxFloat2 = maxFloat / 2;
            WriteLine(isFloat);
            WriteLine(isDouble);
            WriteLine(maxFloat2);

            bool isTrue = true;
            while (isTrue)
            {
                WriteLine("Please enter any number");
                bool isNumber = int.TryParse(ReadLine(), out int number);

                if (isNumber)
                {
                    double precise = Math.Cos(number) / Math.Sin(number);
                    WriteLine($"Cos({number}) / Sin({number}) = {Math.Cos(number)} / {Math.Sin(number)} = {precise}");
                    break;
                }
                WriteLine("You did not enter a valid number!");
                //Welp?

            }
        }
    }
}
