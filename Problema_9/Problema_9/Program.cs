using System;
using System.Linq;

namespace Problema_9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int maxLength = 9, counter = 0;

            Console.Write("Introduceti primul numar (max 9 cifre): ");
            string number1 = Console.ReadLine();
            if (number1.Length > maxLength)
            {
                Console.WriteLine("numarul maxim de cifre depasit. Numarul" +
                    " va fi redus la 9 cifre.");
                number1 = number1.Substring(0, maxLength);
            }
            Console.Write("Introduceti al doilea numar (max 9 cifre): ");
            string number2 = Console.ReadLine();

            if (number2.Length > maxLength)
            {
                Console.WriteLine("numarul maxim de cifre depasit. Numarul" +
                    " va fi redus la 9 cifre.");
                number2 = number2.Substring(0, maxLength);
            }
            string[] result = new string[maxLength];

            for (int i = 0; i < number1.Length; i++)
            {
                for (int j = 0; j < number2.Length; j++)
                {
                    if (number1[i] == number2[j])
                    {
                        result[counter] = Convert.ToString(number1[i]);
                        counter++;
                    }
                }
            }

            Array.Resize(ref result, counter);
            string res = string.Join(", ", result.Distinct());

            Console.Clear();
            Console.Write($"Numerele {number1} si {number2} au " +
                $"{result.Distinct().Count()} cifre comune: {res}.");
        }
    }
}
