using System;

namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Алгоритм: найти число, которое является суммой наибольшего и наименьшего простого множителя заданного числа.\nВведите число N: ");
            uint N = uint.Parse(Console.ReadLine()), d1 = 0, d2 = 0;
            Console.Write("Для числа {0} ", N);
            for (uint d = 2; N != 1; d++)
                if (N % d == 0)
                {
                    if (d1 == 0)
                        d1 = d;
                    else d2 = d;
                    while (N % d == 0)
                        N /= d;
                }
            if (d2 == 0)
                Console.WriteLine(" найти сумму нельзя, так как оно простое.");
            else Console.WriteLine("сумма его наибольшего и наименьшего простых множителей {0} и {1} равна {2}.\n", d1, d2, d1 + d2);
        }
    }
}
