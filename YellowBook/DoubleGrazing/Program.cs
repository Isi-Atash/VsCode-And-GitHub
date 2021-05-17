using System;
using static System.Console;

namespace DoubleGrazing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            double width, height, woodLength, glassArea;

            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;

            string widthString, heightString;

            WriteLine("Give the width of the window: ");
            widthString = ReadLine();
            width = double.Parse(widthString);

            if (width < MIN_WIDTH)
            {
                WriteLine("Width is too small. \n ");
                WriteLine("Using minimum");
                width = MIN_WIDTH;
            }
            if (width > MAX_WIDTH)
            {
                WriteLine("Width is too large. \n");
                WriteLine("Using maximum");
                width = MAX_WIDTH;
            }

            WriteLine("Give the height of the window: ");
            heightString = ReadLine();
            height = double.Parse(heightString);

            if (height < MIN_HEIGHT)
            {
                WriteLine("Height is too small. \n");
                WriteLine("Using minumum");
                height = MIN_HEIGHT;
            }
            if (height > MAX_HEIGHT)
            {
                WriteLine("Height is too large. \n");
                WriteLine("Using maximum");
                height = MAX_HEIGHT;
            }

            woodLength=2*(height+width);
            glassArea=2*(height*width);

            WriteLine($"The length of the wood is {woodLength} meters");
            WriteLine($"The area of the glass is {glassArea} square meters");

        }
    }
}
