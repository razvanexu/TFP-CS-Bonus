using System;

namespace Problema_10
{
    class MainClass
    {
        public static int Trepte(int nrTrepte)
        {
            int treaptaInit = 0, treaptaNext = 1;
            for (int i = 0; i < nrTrepte; i++)
            {
                int temp = treaptaInit;
                treaptaInit = treaptaNext;
                treaptaNext = temp + treaptaNext;
            }
            return treaptaNext;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Introduceti numarul de trepte (Max. 40: )");
            int nrTrepte = Convert.ToInt32(Console.ReadLine());
            int moduri = Trepte(nrTrepte);

            Console.WriteLine($"Nr. de modalitatati pentru a urca {nrTrepte} " +
                $"trepte este de {moduri}");
        }
    }
}
