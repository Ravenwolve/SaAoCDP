using System;

namespace P1_10
{
    internal class Program
    {
        static void delete_string(ref int[][] A, uint str)
        {
            for (uint i = str + 1; i < A.Length; i++)
                A[i - 1] = A[i];
            A[A.Length - 1] = null;
            Array.Resize(ref A, A.Length - 1);
        }
        static void delete_coloumn(ref int[][] A, uint col)
        {
            for (uint i = 0; i < A.Length; i++) 
            {
                for (uint j = col + 1; j < A[i].Length; j++)
                    A[i][j - 1] = A[i][j];
                Array.Resize(ref A[i], A[i].Length - 1);
            }
        }
        static void delete_all_strings(ref int[][] A)
        {
            for (uint i = 0; i < A.Length; i++)
                for (uint j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] != 0)
                        break;
                    if (j == A[i].Length - 1)
                    {
                        delete_string(ref A, i);
                        delete_all_strings(ref A);
                        break;
                    }
                }
        }
        static void delete_all_coloumns(ref int[][] A)
        {
            for (uint i = 0; i < A[0].Length; i++)
                for (uint j = 0; j < A.Length; j++)
                {
                    if (A[j][i] != 0)
                        break;
                    if (j == A.Length - 1)
                    {
                        delete_coloumn(ref A, i);
                        delete_all_coloumns(ref A);
                        break;
                    }
                }
        }
        static void delete_all_nulls(ref int[][] A)
        {
            delete_all_strings(ref A);
            delete_all_coloumns(ref A);
        }
        static void print_array(int[][] Arr)
        {
            for (int i = 0; i < Arr.Length; i++, Console.WriteLine())
                print_array(Arr[i]);
        }
        static void print_array(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
                Console.Write("{0}\t", Arr[i]);
        }
        static void input_array(int[][] Arr)
        {
            for (ushort i = 0; i < Arr.Length; i++)
                for (ushort j = 0; j < Arr[i].Length; j++)
                    Arr[i][j] = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.Write("Алгоритм: Удаление из массива все нулевые строки и столбцы: ");
            int N = int.Parse(Console.ReadLine());
            int[][] A = new int[N][];
            for (int i = 0; i < N; i++)
                A[i] = new int[N];
            input_array(A);
            Console.WriteLine("Исходный массив:");
            print_array(A);
            Console.WriteLine();
            delete_all_nulls(ref A);
            Console.WriteLine("Искомый массив:");
            print_array(A);
        }
    }
}

