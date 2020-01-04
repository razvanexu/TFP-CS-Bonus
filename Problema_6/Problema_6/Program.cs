using System;


namespace Problema_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int indexCand = 0, maxCandidati = 0, maxLocuri = 0,
                drept = 0, info = 0, mate = 0;
            int[] choices = new int[3];

            Console.WriteLine("****************************");
            Console.WriteLine("** Universitatea San Juan **");
            Console.WriteLine("******  Inscrieri  ******");
            Console.WriteLine("****************************");
            Console.WriteLine();

            Console.Write("Nr. Locuri la Drept: ");
            drept = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr. Locuri la Info: ");
            info = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr. Locuri la Mate: ");
            mate = Convert.ToInt32(Console.ReadLine());
            maxLocuri = drept + info + mate;

            Console.Write($"Introduceti numarul de candidati (maxim {maxLocuri}): ");
            maxCandidati = Convert.ToInt32(Console.ReadLine());
            while (maxCandidati > maxLocuri || maxCandidati == 0)
            {
                Console.WriteLine($"Numar invalid de candidati! " +
                    $"Introduceti cel putin un candidat dar maxim {maxLocuri}!");
                Console.Write($"Introduceti numarul de candidati (maxim {maxLocuri}): ");
                maxCandidati = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Candidati[] candidat = new Candidati[maxCandidati];

            while (maxCandidati > indexCand)
            {
                Console.Write($"Numele candidatului {indexCand}: ");
                string nume = Console.ReadLine();
                Console.Write("Nota Matematica: ");
                int nM = Convert.ToInt32(Console.ReadLine());
                while (nM < 0 || nM > 10)
                {
                    Console.Clear();
                    Console.WriteLine("Nota invalida. Reincercati.");
                    Console.Write("Nota Matematica: ");
                    nM = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Nota Limba Romana: ");
                int nR = Convert.ToInt32(Console.ReadLine());
                while (nR < 0 || nR > 10)
                {
                    Console.WriteLine("Nota invalida. Reincercati.");
                    Console.Write("Nota Limba Romana: ");
                    nR = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Nota Fizica: ");
                int nF = Convert.ToInt32(Console.ReadLine());
                while (nF < 0 || nF > 10)
                {
                    Console.WriteLine("Nota invalida. Reincercati.");
                    Console.Write("Nota Fizica: ");
                    nF = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Alegeti cele 3 profile:");
                Console.WriteLine("1 = Drept, 2 = Info, 3 = Mate");
                for (int i = 0; i < choices.Length; i++)
                {
                    Console.Write($"Profilul nr {i}: ");
                    choices[i] = Convert.ToInt32(Console.ReadLine()) - 1;
                    while (choices[i] < 0 || choices[i] > 2)
                    {
                        Console.WriteLine("Numar invalid. Reincercati.");
                        Console.WriteLine("1 = Drept, 2 = Info, 3 = Mate");
                        Console.Write($"Profilul nr {i}: ");
                        choices[i] = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                }

                Candidati candidati = new Candidati(nume, nM, nR, nF);
                if (candidati.GetMedia() >= 6)
                {
                    candidat[indexCand] = candidati;
                    candidat[indexCand].SetChoice(choices);
                    indexCand++;
                }
                else
                {
                    Console.WriteLine("Candidatul nu se califica");
                }
            }

            while (drept != 0 && info != 0 && mate != 0)
            {
                for (int j = 0; j < indexCand; j++)
                {
                    switch (candidat[j].GetChoices(0))
                    {
                        case 0:
                            choices = candidat[j].GetAllChoices();
                            if (drept <= 0)
                            {
                                choices[0] = choices[1];
                                if (choices[0] == 1 && info > 0)
                                {
                                    candidat[j].SetChoice(choices);
                                    info--;
                                }
                                else if (choices[0] == 2 && mate > 0)
                                {
                                    candidat[j].SetChoice(choices);
                                    mate--;
                                }
                                else
                                {
                                    choices[0] = choices[2];
                                    if (choices[0] == 1 && info > 0)
                                    {
                                        candidat[j].SetChoice(choices);
                                        info--;
                                    }
                                    else
                                    {
                                        candidat[j].SetChoice(choices);
                                        mate--;
                                    }
                                }
                            }
                            else
                            {
                                candidat[j].SetChoice(choices);
                                drept--;
                            }

                            break;
                        case 1:
                            choices = candidat[j].GetAllChoices();
                            if (info <= 0)
                            {
                                choices[0] = choices[1];
                                if (choices[0] == 0 && drept > 0)
                                {
                                    candidat[j].SetChoice(choices);
                                    drept--;
                                }
                                else if (choices[0] == 2)
                                {
                                    candidat[j].SetChoice(choices);
                                    mate--;
                                }
                                else
                                {
                                    choices[0] = choices[2];
                                    if (choices[0] == 0 && drept > 0)
                                    {
                                        candidat[j].SetChoice(choices);
                                        drept--;
                                    }
                                    else
                                    {
                                        candidat[j].SetChoice(choices);
                                        mate--;
                                    }
                                }
                            }
                            else
                            {
                                candidat[j].SetChoice(choices);
                                info--;
                            }

                            break;
                        case 2:
                            choices = candidat[j].GetAllChoices();
                            if (mate <= 0)
                            {
                                choices[0] = choices[1];
                                if (choices[0] == 0 && drept > 0)
                                {
                                    candidat[j].SetChoice(choices);
                                    drept--;
                                }
                                else if (choices[0] == 1)
                                {
                                    candidat[j].SetChoice(choices);
                                    info--;
                                }
                                else
                                {
                                    choices[0] = choices[2];
                                    if (choices[0] == 0 && drept > 0)
                                    {
                                        candidat[j].SetChoice(choices);
                                        drept--;
                                    }
                                    else
                                    {
                                        candidat[j].SetChoice(choices);
                                        info--;
                                    }
                                }
                            }
                            else
                            {
                                candidat[j].SetChoice(choices);
                                info--;
                            }

                            break;
                    }
                }
            }

            Console.Clear();

            Console.WriteLine("****************************");
            Console.WriteLine("** Universitatea San Juan **");
            Console.WriteLine("******  Lista Admisi  ******");
            Console.WriteLine("****************************");
            Console.WriteLine();

            foreach (Candidati candidati1 in candidat)
            {
                if (candidati1 == null)
                {
                    Console.WriteLine("Nu exista candidati.");
                }
                Console.WriteLine($"{candidati1.GetNume()} admis la profilul " +
                    $"{(Materii)candidati1.GetChoices(0)}.");
            }
        }
    }
}
