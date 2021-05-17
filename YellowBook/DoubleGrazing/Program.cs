using System;
using static System.Console;

namespace DoubleGrazing
{
    class Program
    {
        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_HEIGHT = 0.75;

        
        static void Main(string[] args)
        {
            // DoubleGrazing1();
            DoubleGrazing2();
        }


        static void DoubleGrazing1()
        {
            double width, height, woodLength, glassArea;
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

            woodLength = 2 * (height + width);
            glassArea = 2 * (height * width);

            WriteLine($"The length of the wood is {woodLength} meters");
            WriteLine($"The area of the glass is {glassArea} square meters");
        }

        static void DoubleGrazing2()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            do
            {
                Write($"Give the width of the window between {MIN_WIDTH} and {MAX_WIDTH}: ");
                widthString = ReadLine();
                width = double.Parse(widthString);
            } while (width < MIN_WIDTH || width > MAX_WIDTH);

            do
            {
                Write($"Give the height of the window between {MIN_HEIGHT} and {MAX_HEIGHT}");
                heightString = ReadLine();
                height = double.Parse(heightString);
            } while (height < MIN_HEIGHT || height > MAX_HEIGHT);

            woodLength = 2 * (height + width);
            glassArea = 2 * (height * width);

            WriteLine($"The length of the wood is {woodLength} meters");
            WriteLine($"The area of the glass is {glassArea} square meters");

        }

        //Branch mi yazinaram indi?
        //I dunno
        //I hope its just i think it is...
    }
}
