using System;
using System.Globalization;
using System.Threading;

namespace Problema_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduceti data nasterii (dd.mm.yyyy): ");

            string bDay = Console.ReadLine();

            Console.WriteLine("Introduceti data curenta (dd.mm.yyyy): ");

            string curDate = Console.ReadLine();
            string format = "dd.mm.yyyy";
            CultureInfo culture = CultureInfo.InvariantCulture;

            DateTime bDate = DateTime.ParseExact(bDay, format, culture);
            DateTime curDay = DateTime.ParseExact(curDate, format, culture);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine($" Varsta: {Math.Floor(((curDay - bDate).TotalDays) / 365)} ani");
            Console.WriteLine($" Ati trait {(curDay - bDate).TotalDays} zile.");
            Console.WriteLine("========================");
            Console.WriteLine();

        }
    }
}
