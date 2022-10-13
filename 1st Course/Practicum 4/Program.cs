using System;

namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Алгоритм: найти число, которое является суммой наибольшего и наименьшего простого множителя заданного числа.\nВведите число N: ");
            uint N = uint.Parse(Console.ReadLine()), div_min = 0, div_max = 0;
            Console.Write("Для числа {0} ", N);
            if (N == 1 || N == 0)
            {
                Console.WriteLine("нет делителей.");
            }
            else
            {
                for (uint n = N, d = 2; n != 1; d++)
                    if (n % d == 0)
                    {
                        if (div_min == 0)
                            div_min = d;
                        else div_max = d;
                        while (n % d == 0)
                            n /= d;
                    }
                if (div_min == N)
                    Console.WriteLine("найти сумму нельзя, так как оно простое.");
                else if (div_max == 0)
                    Console.WriteLine("существует лишь один простой делитель - {0}.", div_min);
                else Console.WriteLine("сумма его наибольшего и наименьшего простых множителей {0} и {1} равна {2}.",
                    div_min, div_max, div_min + div_max);
            }
        }
    }
}
