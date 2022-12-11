using System;
namespace P1_10
{
    internal class Program
    {
        public static void Decompose(int number, int branch = 0, int index = 0, int[] Terms = null)
        {
            if (number >= 0)
            {
                if (branch == 0)
                {
                    branch = number - 1;
                    Terms = new int[number + 1];
                }
                int iter = 1;
                do
                {
                    Terms[index] = branch;
                    Decompose(number - iter, iter, index + 1, Terms);
                    iter++;
                }
                while (iter <= Math.Min(number, branch));
            }
            else PrintTerms(Terms, index - 1);
        }
        private static void PrintTerms(int[] Terms, int lastIndex)
        {
            if (lastIndex > 0)
            {
                for (int i = lastIndex; i > 1; i--)
                    Console.Write("{0}+", Terms[i]);
                Console.Write("{0}={1}", Terms[1], Terms[0] + 1);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число, которое хотите разложить на слагаемые: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
                Decompose(n);
            else Console.WriteLine("Ошибка: отрицательное число");
        }
    }
}
