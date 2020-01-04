using System;

namespace Problema_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool isVowel(string c)
            {
                string vowels = "aeiou";
                foreach (char vow in vowels)
                {
                    foreach (char car in c)
                    {
                        if (car == vow)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            bool areEqual(int[] v1, int[] v2)
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    if (v1[i] != v2[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            string c1, c2;
            Console.WriteLine($"Introduceti primul cuvant: ");
            c1 = Console.ReadLine();
            Console.WriteLine($"Introduceti al doilea cuvant: ");
            c2 = Console.ReadLine();
            int len = c1.Length;
            int[] vC1 = new int[len];
            int[] vC2 = new int[len];

            for (int i = 0; i < len; i++)
            {
                vC1[i] = Convert.ToInt32(isVowel(Convert.ToString(c1[i]).ToLower()));
                vC2[i] = Convert.ToInt32(isVowel(Convert.ToString(c2[i]).ToLower()));
            }

            if (areEqual(vC1, vC2))
            {
                Console.WriteLine($"Cuvantul {c1} are acceasi textura cu {c2}");
            }
            else
            {
                Console.WriteLine("Cuvintele nu au aceeasi textura.");
            }

        }
    }
}
