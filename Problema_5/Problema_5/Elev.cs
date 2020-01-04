using System;
namespace Problema_4
{
    public class Elev
    {
        private string nume, prenume;
        private decimal mediaGen;

        public Elev(string nume, string prenume, decimal mediaGen)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.mediaGen = mediaGen;
        }

        public string GetNume()
        {
            return nume;
        }

        public string GetPrenume()
        {
            return prenume;
        }

        public decimal GetMg()
        {
            return mediaGen;
        }

        public static Elev[] GetSort(Elev[] elevi, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (elevi[j].mediaGen < elevi[j + 1].mediaGen)
                    {
                        Elev temp = elevi[j];
                        elevi[j] = elevi[j + 1];
                        elevi[j + 1] = temp;
                    }
                }
            }
            return elevi;
        }
    }
}
