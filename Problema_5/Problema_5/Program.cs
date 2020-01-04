using System;

namespace Problema_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Introduceti numarul elevilor: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Elev[] elevi = new Elev[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nume elev {i}: ");
                string nume = Console.ReadLine();
                while (nume.Length > 20 || nume.Length == 0)
                {
                    if (nume.Length > 20)
                    {
                        Console.WriteLine("Nume prea lung, max. 20 caractere, reincercati");
                    }
                    if (nume.Length == 0)
                    {
                        Console.WriteLine("Nu ati introdus niciun caracter, reincercati.");
                    }
                    Console.Write($"Nume elev {i}: ");
                    nume = Console.ReadLine();
                }
                Console.Write($"Prenume elev {i}: ");
                string prenume = Console.ReadLine();
                while (prenume.Length > 20 || nume.Length == 0)
                {
                    if (prenume.Length > 20)
                    {
                        Console.WriteLine("Prenume prea lung, max. 20 caractere, reincercati");
                    }
                    if (prenume.Length == 0)
                    {
                        Console.WriteLine("Nu ati introdus niciun caracter, reincercati.");
                    }
                    Console.Write($"Prenume elev {i}: ");
                    prenume = Console.ReadLine();
                }
                Console.Write($"Medie Generala: ");
                decimal mediaGen = Convert.ToDecimal(Console.ReadLine());

                elevi[i] = new Elev(nume, prenume, mediaGen);
            }

            Console.WriteLine();

            Elev.GetSort(elevi, n);

            foreach (Elev elev in elevi)
            {
                Console.WriteLine($"Media generala a elevului {elev.GetNume()} " +
                    $"{elev.GetPrenume()} - {elev.GetMg()}: ");
            }


        }
    }
}
