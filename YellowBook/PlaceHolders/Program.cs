using System;
using static System.Console;

namespace PlaceHolders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int i = 15;
            double f = 1234.56789;

            WriteLine("\ni: {0} f: {1}", i, f);
            WriteLine("i: {1} f: {0}\n", f, i);

            WriteLine($"i: {i} f: {f}\n");

            WriteLine("i: {0:0} f: {1:0}\n", i, f);
            WriteLine("i: {0:0.0} f: {1:0.0}\n", i, f);
            WriteLine("i: {0:000.00} f: {1:00.00}\n", i, f);
            WriteLine("i: {0:#,##0:} f: {1:##,##0.00}\n", i, f);

            WriteLine("i: {0,-5:0} f: {1,-10:0.00}\n", i, f);

            string ad, soyad, ataAd, anaAd, baciAd;
            ad = "ElgunElgunElgun";
            soyad = "Ramizli";
            ataAd = "Ruslan";
            anaAd = "Nezrin";
            baciAd = "Kemale";

            WriteLine("ad: {0,5} soyad: {1,5} Ata Ad: {2,5} Ana Ad: {3,5} Baci Ad: {4,5}", ad, soyad, ataAd, anaAd, baciAd);
            WriteLine("ad: {0,10} soyad: {1,10} Ata Ad: {2,10} Ana Ad: {3,10} Baci Ad: {4,10}", ad, soyad, ataAd, anaAd, baciAd);


        }
    }
}
