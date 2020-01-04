using System;
namespace Problema_4
{
    public class Elev
    {
        private string nume, prenume;
        private decimal medieMate;
        private int tezaMate;

        public Elev(string nume, string prenume, decimal medieMate, int tezaMate)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.medieMate = medieMate;
            this.tezaMate = tezaMate;
        }

        public string GetNume()
        {
            return nume;
        }

        public string GetPrenume()
        {
            return prenume;
        }

        public decimal GetMm()
        {
            return medieMate;
        }

        public int GetTm()
        {
            return tezaMate;
        }
    }
}
