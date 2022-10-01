using System;

namespace P1_10
{
    internal class Program
    {
        static double[,] get_minor(double[,] A, uint size, uint col)
        {
            double[,] minor = new double[size - 1, size - 1];
            if (col == 0) //Если минор по первому элементу строки
                for (ushort i = 1; i < size; i++)
                    for (ushort j = 1; j < size; j++)
                        minor[i - 1, j - 1] = A[i, j];
            else for (ushort i = 1; i < size; i++)
                {
                    for (ushort j = 0; j < col; j++)
                        minor[i - 1, j] = A[i, j];
                    for (uint j = col + 1; j < size; j++)
                        minor[i - 1, j - 1] = A[i, j];
                }
            return minor;
        }
        static double det(double[,] matrix, uint size)
        {
            if (size == 1)
                return matrix[0, 0];
            else if (size == 2)
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            else
            {
                double sum = 0;
                for (uint j = 0; j < size; j++)
                {
                    if (j % 2 == 0)
                        sum += matrix[0, j] * det(get_minor(matrix, size, j), size - 1);
                    else sum -= matrix[0, j] * det(get_minor(matrix, size, j), size - 1);
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы: ");
            ushort N = ushort.Parse(Console.ReadLine());
            double[,] Arr = new double[N, N];
            for (ushort i = 0; i < N; i++)
                for (ushort j = 0; j < N; j++)
                {
                    Console.Write("Введите элемент A[{0},{1}]: ", i, j);
                    Arr[i, j] = double.Parse(Console.ReadLine());
                }
            Console.WriteLine("Детерминант заданной матрицы равен {0}", det(Arr, N));
        }
    }
}
