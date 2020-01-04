using System;

namespace Problema_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduceti textul");
            string text = Console.ReadLine();

            string[] splitedText = text.Split(new char[] { ' ', ',', ';' });

            foreach (string word in splitedText)
            {
                if (word.Trim() != "")
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
