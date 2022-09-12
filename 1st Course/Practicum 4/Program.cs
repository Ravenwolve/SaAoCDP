using System;
using System.Data.SqlTypes;

namespace P1_10 {
    internal class Program {
        static bool is_it_a_sim_div(int n) {
            for (int s = 2; s <= Math.Sqrt(n); s++)
            {
                if (n % s == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args) {
            Console.Write("Алгоритм: найти число, которое является суммой наибольшего и наименьшего простого множителя заданного числа.\nВведите число N: ");
            int N = int.Parse(Console.ReadLine()), N_sum_of_sim_divs = 0;
            sbyte step = 1;
            for (int d = 2, end = N/2 + 1; d != end; d += step)
            {
                if (is_it_a_sim_div(d) && N % d == 0)
                {
                    N_sum_of_sim_divs += d;
                    if (step < 0)
                        break;
                    step *= -1;
                    d = N / 2 + 1;
                    end = N_sum_of_sim_divs;
                }
            }
            Console.WriteLine("Для числа {0} сумма его наибольшего и наименьшего простых множителей равна {1}.", N, N_sum_of_sim_divs);
        }
    }
}
