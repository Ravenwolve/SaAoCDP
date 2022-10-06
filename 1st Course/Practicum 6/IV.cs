using System;

namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Алгоритм: Для каждого столбца найти первый положительный элемент и записать данные в новый массив.\nВведите размерность квадратного массива: ");
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[N,N];
            for (ushort i = 0; i < N; i++)
                for (ushort j = 0; j < N; j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            /*
    1    -2      -3       0
   -5    -6      -7      -8
    9    -10     -11     12
   -13    14     -12     13
            Вывод: 1 14 12
*/
            Console.WriteLine("Ваш массив: ");
            for (ushort i = 0; i < N; i++, Console.WriteLine())
                for (ushort j = 0; j < N; j++)
                    Console.Write("{0} ", A[i, j]);
            ushort num = 0;
            int[] Result = new int[N];
            for (ushort i = 0; i < N; i++)
                for (ushort j = 0; j < N; j++)
                {
                    if (A[j, i] > 0)
                    {
                        Result[num] = A[j, i];
                        num++;
                        break;
                    }
                }
            int[] New_Result = new int[num];
            Array.Copy(Result, New_Result, New_Result.Length);
            Console.WriteLine("Получившийся массив:");
            foreach (int item in New_Result)
                Console.Write("{0} ", item);
        }
    }
}