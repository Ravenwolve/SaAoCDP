using System;

namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Алгоритм: найти число, которое является суммой наибольшего и наименьшего простого множителя заданного числа.\nВведите число N: ");
            uint N = uint.Parse(Console.ReadLine()), FirstD = 0, LastD = 0;
            uint mem_N = N;
            for (uint d = 2; N != 1; d++)
            {
                while (N % d == 0)
                {
                    N /= d;
                }
                if (FirstD == 0)
                    FirstD = d;
                else LastD = d;
            }
            Console.WriteLine("Для числа {0} сумма его наибольшего и наименьшего простых множителей равна {1}.", mem_N, FirstD + LastD);
        }
    }
}
