using System;

namespace Problema_1
{
    class checkPrime
    {
        public static bool isPrime(int num)
        {
            int i, notPrime = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    notPrime = 1;
                    break;
                }
            }
            if (notPrime == 1)
            {
                return false;
            }
            return true;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nr. randuri: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int column = row;
            Console.Write($"Nr. coloane: {column}");
            Console.WriteLine();

            int[,] squaredMatrix = new int[column, row];
            int max = squaredMatrix[0, 0];
            int counter = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"rand{i}, coloana{j}: ");
                    squaredMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{squaredMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = i + 1; j < column; j++)
                {
                    if (squaredMatrix[i, j] > max)
                    {
                        max = squaredMatrix[i, j];
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = column - i; j < column; j++)
                {
                    if (checkPrime.isPrime(squaredMatrix[i, j]) == true)
                    {
                        counter += 1;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Nr maxim deasupra diagonalei principale: {max}");
            Console.Write($"Sub diagonala secundara sunt {counter} nr. prime ");
        }
    }
}
