using System;
using System.Collections.Generic;
namespace P1_10
{
    internal class Program
    {
        static double middle_div(uint n)
        {
            List<double> divides = new List<double>();
            for (uint d = 1; d <= n / 2; d++)
                if (n % d == 0)
                    divides.Add(d);
            divides.Add(n);
            return (divides[divides.Count / 2] + divides[(divides.Count - 1) / 2]) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a) Для каждого целого числа на отрезке [a, b] вывести на экран медиану его делителей. Введите a, затем b: ");
            uint a = uint.Parse(Console.ReadLine()), b = uint.Parse(Console.ReadLine());
            //---------------------------------------------- A --------------------------------------------------
            Console.WriteLine("Число \t Медиана делителей");
            for (uint i = a; i <= b; i++)
                Console.WriteLine("{0} \t {1}", i, middle_div(i));
            //---------------------------------------------- B --------------------------------------------------
            double max = 0;
            double middle;
            Console.WriteLine("b) На отрезке [a, b] найти все числа, имеющие наибольшую медиану делителей.");
            for (uint i = a; i <= b; i++)
            {
                middle = middle_div(i);
                if (middle > max)
                    max = middle;
            }
            Console.Write("Максимальная медиана делителей {0}. Числа, имеющие данную медиану:", max);
            for (uint i = a; i <= b; i++)
                if (middle_div(i) == max)
                    Console.Write(" {0}", i);
            Console.WriteLine('.');
            //---------------------------------------------- C --------------------------------------------------
            Console.Write("c) На отрезке [a, b] найти все числа, медиана делителей которых равно числу С. Введите число C: ");
            double C = double.Parse(Console.ReadLine());
            Console.Write("Числа, медианой делителей которых является {0}:", C);
            for (uint i = a; i <= b; i++)
                if (middle_div(i) == C)
                    Console.Write(" {0}", i);
            Console.WriteLine('.');
            //---------------------------------------------- D --------------------------------------------------
            Console.Write("d) Для заданного числа А вывести на экран ближайшее следующее за ним число, медиана делителей которого равна медиане делителей числа А. Введите число A: ");
            uint A = uint.Parse(Console.ReadLine());
            middle = middle_div(A);
            for (uint i = A + 1; i < A + 1000; i++)
                if (middle_div(i) == middle)
                {
                    Console.WriteLine("Ближайшее следующее число за {0} это {1}.", A, i);
                    break;
                }
        }
    }
}
