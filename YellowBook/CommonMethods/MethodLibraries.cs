using System;
using static System.Console;

namespace YellowBook.CommonMethods
{
    public class MethodLibraries
    {
        public MethodLibraries()
        {

        }
        static string ReadString(string prompt)
        {
            string result;
            do
            {
                Write(prompt);
                result = ReadLine();

            } while (result = "");
            return result;
        }
    }
}