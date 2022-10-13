using System;

namespace P1_10
{
    internal class Program
    {
        static void input_array(int[,] Arr)
        {
            for (ushort i = 0; i < Arr.GetLength(0); i++)
                for (ushort j = 0; j < Arr.GetLength(0); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    Arr[i, j] = int.Parse(Console.ReadLine());
                }
        }
        static void output_array(int[,] Arr)
        {
            for (ushort i = 0; i < Arr.GetLength(0); i++, Console.WriteLine())
                for (ushort j = 0; j < Arr.GetLength(0); j++)
                    Console.Write("{0}\t", Arr[i, j]);
        }
        static void output_array(int[] Arr)
        {
            foreach (int item in Arr)
                Console.Write("{0}\t", item);
        }
        static int[] each_first_positive_for(int[,] Arr)
        {
            ushort count = 0;
            for (ushort i = 0; i < Arr.GetLength(0); i++)
                for (ushort j = 0; j < Arr.GetLength(0); j++)
                {
                    if (Arr[j, i] > 0)
                    {
                        count++;
                        break;
                    }
                }
            int[] Result = new int[count];
            for (ushort i = 0, k = 0; i < Arr.GetLength(0); i++)
                for (ushort j = 0; j < Arr.GetLength(0); j++)
                {
                    if (Arr[j, i] > 0)
                    {
                        Result[k] = Arr[j, i];
                        k++;
                        break;
                    }
                }
            return Result;
        }
        static void Main(string[] args)
        {
            Console.Write("Алгоритм: Для каждого столбца найти первый положительный элемент и записать данные в новый массив.\nВведите размерность квадратного массива: ");
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[N, N];
            input_array(A);
/*  1    -2      -3       0
   -5    -6      -7      -8
    9    -10     -11     12
   -13    14     -12     13
            Вывод: 1 14 12 */
            Console.WriteLine("Ваш массив: ");
            output_array(A);
            Console.WriteLine("Получившийся массив:");
            int[] Result = each_first_positive_for(A);
            output_array(Result);
        }
    }
}
