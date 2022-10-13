using System;

namespace P1_10
{
    internal class Program
    {
        static double[,] get_minor(double[,] A, uint col)
        {
            double[,] minor = new double[A.GetLength(0) - 1, A.GetLength(0) - 1];
            if (col == 0) //Если минор по первому элементу строки
                for (ushort i = 1; i < A.GetLength(0); i++)
                    for (ushort j = 1; j < A.GetLength(0); j++)
                        minor[i - 1, j - 1] = A[i, j];
            else for (ushort i = 1; i < A.GetLength(0); i++)
                {
                    for (ushort j = 0; j < col; j++)
                        minor[i - 1, j] = A[i, j];
                    for (uint j = col + 1; j < A.GetLength(0); j++)
                        minor[i - 1, j - 1] = A[i, j];
                }
            return minor;
        }
        static double det(double[,] matrix)
        {
            if (matrix.GetLength(0) == 1)
                return matrix[0, 0];
            else if (matrix.GetLength(0) == 2)
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            else
            {
                double sum = 0;
                for (uint j = 0; j < matrix.GetLength(0); j++)
                {
                    if (j % 2 == 0)
                        sum += matrix[0, j] * det(get_minor(matrix, j));
                    else sum -= matrix[0, j] * det(get_minor(matrix, j));
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
                    Console.Write("Введите элемент A[{0},{1}]: ", i + 1, j + 1);
                    Arr[i, j] = double.Parse(Console.ReadLine());
                }
            Console.WriteLine("Детерминант заданной матрицы равен {0}", det(Arr));
        }
    }
}
