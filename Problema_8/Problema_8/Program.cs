using System;

namespace Problema_8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int maxLength = 300;

            Console.WriteLine("Introduceti fraza de analizat (max 300 caractere:) ");
            string input = Console.ReadLine();
            //string input = "cand*lucreaza**pe*grupe***copiii*trebuie*sa*coopereze";

            if (input.Length > maxLength)
            {
                Console.WriteLine("Limita de 300 de caractere a fost depasita." +
                    "Fraza va fi scurtata pana la limita.");
                input = input.Substring(0, maxLength);
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1] && input[i] != '*')
                {
                    Console.WriteLine($"{input[i]} {input[i + 1]}");
                }
            }


        }
    }
}
