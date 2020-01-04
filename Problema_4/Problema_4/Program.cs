using System;

namespace Problema_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int mediaMateGen;
            Console.Write("Introduceti numarul elevilor: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Elev[] elevi = new Elev[n];
            Elev[] corijenti = new Elev[n];
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
                Console.Write($"Medie Mate {i}: ");
                decimal medieNoteMate = Convert.ToDecimal(Console.ReadLine());
                Console.Write($"Teza Mate {i}: ");
                int tezaMate = Convert.ToInt32(Console.ReadLine());

                elevi[i] = new Elev(nume, prenume, medieNoteMate, tezaMate);
            }

            Console.WriteLine();
            int counter = 0;
            int[] mediaFinMate = new int[n];


            for (int i = 0; i < n; i++)
            {
                mediaMateGen = Convert.ToInt32((elevi[i].GetMm() * 3 + elevi[i].GetTm()) / 4);

                if (mediaMateGen < 5)
                {
                    mediaFinMate[i] = mediaMateGen;
                    corijenti[i] = elevi[i];
                    counter++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (mediaFinMate[i] == 0)
                {
                    mediaFinMate[i] = mediaFinMate[i + 1];
                    corijenti[i] = corijenti[i + 1];
                }
            }

            for (int i = 0; i < counter - 1; i++)
            {
                for (int j = 0; j < counter - i - 1; j++)
                {
                    if (mediaFinMate[j] < mediaFinMate[j + 1])
                    {
                        int temp2 = mediaFinMate[j];
                        mediaFinMate[j] = mediaFinMate[j + 1];
                        mediaFinMate[j + 1] = temp2;

                        Elev temp = corijenti[j];
                        corijenti[j] = corijenti[j + 1];
                        corijenti[j + 1] = temp;
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Felicitari, niciun elev corijent!");
            }
            else
            {
                Console.WriteLine("Elevii corijenti la matematica:");
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine($"{corijenti[i].GetNume()} {corijenti[i].GetPrenume()} - " +
                          $"media {mediaFinMate[i]}");
                }
            }
        }
    }
}
