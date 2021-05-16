using System;
using static System.Console;

namespace Exercise_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            numberOfBytesInMemoryOfNumberTypes();
        }

        static void testStringFormat()
        {
            // Console.WriteLine(
            // format: "{0,0} {1,10:N0} {2,20:N0} {3,100:N0}",
            // arg0: "Type",
            // arg1: "Byte(s) of memory",
            // arg2: "Min",
            // arg3: "Max");

            Console.WriteLine(
            format: "{0,0} {1,10:N0} {2,20:N0} ",
            arg0: "Type",
            arg1: "Byte(s) of memory",
            arg2: "Min"
            );

            string applesText = "Apples";
            int applesCount = 1234;

            Console.WriteLine(
            format: "{0,0} {1,20:N0}",
            arg0: "Name",
            arg1: "Count");

            Console.WriteLine(
            format: "{0,0} {1,20:N0}",
            arg0: applesText,
            arg1: applesCount);

            // Console.WriteLine(
            // format: "{0,0} {1,10:N0} {2,20:N0} {3,100:N0}",
            // arg0: "Type",
            // arg1: "Byte(s) of memory",
            // arg2: "Min",
            // arg3: "Max");
        }
  

        public static void  numbers()
        {
            // Console.WriteLine("Hello World!");
            
            //A person's telephone number:
            Write("Please enter your phone number: ");
            string personPhoneNumber=ReadLine();
            WriteLine($"{personPhoneNumber} is good number.");

            //A person's height
            Write("Please enter your height: ");
            decimal personHeight=decimal.Parse( ReadLine());
            WriteLine($"Your height is {personHeight}.");
            
        }

        static void  numberOfBytesInMemoryOfNumberTypes()
        {
            //Create a console application project named Exercise02 that outputs the number
            // of bytes in memory that each of the following number types use, and the minimum
            // and maximum values they can have: 
            //sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
            
            string[] elementNames={"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float",  "decimal"};

            object[] sizeOfElements={ sizeof(sbyte),sizeof(byte),sizeof(short),sizeof(ushort),sizeof(int),
            sizeof(uint),sizeof(long),sizeof(ulong),sizeof(float),sizeof(decimal) };

            object[] minValueElement={sbyte.MinValue,byte.MinValue,short.MinValue,ushort.MinValue,int.MinValue,
            uint.MinValue,long.MinValue,ulong.MinValue,float.MinValue,decimal.MinValue};

            object[] maxValueElement={sbyte.MaxValue,byte.MaxValue,short.MaxValue,ushort.MaxValue,int.MaxValue,
            uint.MaxValue,long.MaxValue,ulong.MaxValue,float.MaxValue,decimal.MaxValue};

            WriteLine("{0,-50} {1,-40} {2,-20} {3,30}\n", "Type", "Byte(s) of memory", "Min", "Max");

            for (int i = 0; i < elementNames.Length; i++)
            {
                WriteLine("{0,-50} {1,-40:N0} {2, -20:N0} {3,30:N0}",elementNames[i],sizeOfElements[i],minValueElement[i],maxValueElement[i]);
            }

        }
        static void howToAlign()
        {
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            Console.WriteLine(
            format: "{0,0} {1,20:N0}",
            arg0: "Name",
            arg1: "Count");


            Console.WriteLine(
            format: "{0,0} {1,20:N0}",
            arg0: applesText,
            arg1: applesCount);


            Console.WriteLine(
            format: "{0,0} {1,20:N0}",
            arg0: bananasText,
            arg1: bananasCount);
        }
    }
}
