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
            if (N == 1 || N == 0) {
                Console.WriteLine("нет делителей.");
            }
            else
            {
                for (uint n = N, d = 2; n != 1; d++)
                    if (n % d == 0)
                    {
                        if (d1 == 0)
                            d1 = d;
                        else d2 = d;
                        while (n % d == 0)
                            n /= d;
                    }
                if (d1 == N)
                    Console.WriteLine("найти сумму нельзя, так как оно простое.");
                else if (d2 == 0)
                    Console.WriteLine("существует лишь один простой делитель - {0}.", d1);
                else Console.WriteLine("сумма его наибольшего и наименьшего простых множителей {0} и {1} равна {2}.", d1, d2, d1 + d2);
            }
        }
    }
}
