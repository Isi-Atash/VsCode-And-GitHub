using System;
using static System.Console;

public class MethodLibraries
{
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