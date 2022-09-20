using System;

namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Алгоритм: найти число, которое является суммой наибольшего и наименьшего простого множителя заданного числа.\nВведите число N: ");
            uint N = uint.Parse(Console.ReadLine()), d1 = 0, d2 = 0;
            Console.Write("Для числа {0} сумма его наибольшего и наименьшего простых множителей ", N);
            for (uint d = 2; N != 1; d++)
            {
                while (N % d == 0)
                    N /= d;
                if (d1 == 0)
                {
                    d1 = d;
                    Console.Write("{0} и ", d);
                }
                else d2 = d;
            }
            Console.WriteLine("{0} равна {1}.\n", d2, d1 + d2);
        }
    }
}
