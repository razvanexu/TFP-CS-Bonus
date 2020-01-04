using System;
namespace Problema_6
{
    class Candidati
    {
        private string nume;
        private int notaMate, notaRom, notaFiz;
        private double media;
        int[] choices = new int[3];

        public Candidati(string nume, int notaMate, int notaRom, int notaFiz)
        {
            this.nume = nume;
            this.notaMate = notaMate;
            this.notaRom = notaRom;
            this.notaFiz = notaFiz;
        }

        public string GetNume()
        {
            return nume;
        }

        public double GetMedia()
        {
            return media = (notaRom + notaMate + notaFiz) / 3;
        }

        public void SetChoice(int[] choices)
        {
            for (int i = 0; i < this.choices.Length; i++)
            {
                this.choices[i] = choices[i];
            }
        }

        public int[] GetAllChoices()
        {
            return choices;
        }

        public int GetChoices(int index)
        {
            return choices[index];
        }
    }
}
