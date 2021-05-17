using System;
using System.Drawing;
using System.Runtime.InteropServices;
// using Microsoft.Office.Interop.Excel;

namespace Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Application xlApp = new Application();
            // Workbook xlWorkBook;
            // Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            // xlWorkBook = xlApp.Workbooks.Add(misValue);
            // xlWorkSheet = (Worksheet)xlWorkBook.ActiveSheet;

            string filePath=@"C:\Users\Ismayil3\Desktop\Extra\Repos\VsCode-And-GitHub\Tests";
            // xlWorkBook.Close(true, filePath, misValue);
            System.Diagnostics.Process.Start(filePath);

        }
    }
}
