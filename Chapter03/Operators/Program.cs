using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // UnaryArithmeticOperations();  
            // BinaryArithmeticOperators();
            AssignmentOperators();


        }

        static void UnaryArithmeticOperators()
        {
            int a=3;
            int b=a+1;
            WriteLine($"a is {a} and b is {b}.");

            int c=3;
            int d=c+1;
            WriteLine($"c is {c} and b is {d}.");
        }

        static void BinaryArithmeticOperators()
        {
            Write("Please enter number : ");            
            int e=int.Parse(ReadLine());

            Write("Please enter number: ");
            int f=int.Parse(ReadLine());

            WriteLine($"e is {e} and f is {f}");
            WriteLine($"e + f = {e+f}");
            WriteLine($"e - f = {e-f}");
            WriteLine($"e * f = {e*f}");
            WriteLine($"e / f = {e/f}");
            WriteLine($"e % f = {e%f}");

            double g=11.0;
            WriteLine($"g is {g:N1} and f is {f}");
            WriteLine($"g / f = {g/f}");

        }
        
        static void AssignmentOperators()
        {
            Write("Please enter random number: ");
            int p=int.Parse(ReadLine());
            p+=3;
            WriteLine(p);
            p-=3;
            WriteLine(p);
            p*=3;
            WriteLine(p);
            p/=3;
            WriteLine(p);
        }


    }
}
