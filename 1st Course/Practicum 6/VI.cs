using System;
using System.Xml.Schema;

namespace P1_10
{
    internal class Program
    {
        static void DeleteRow(ref int[][] Arr, int Row, int Length)
        {
            for (int i = Row + 1; i < Length; i++)
                Arr[i - 1] = Arr[i];
            Arr[Length - 1] = null;
        }
        static void DeleteColoumn(ref int[][] Arr, int Col, int Length)
        {
            for (int i = 0; i < Arr.Length; i++)
                for (int j = Col + 1; j < Length; j++)
                    Arr[i][j - 1] = Arr[i][j];
        }
        static void DeleteNulls(ref int[][] Arr)
        {
            int NewLength = Arr.Length;
            for (int i = 0; i < NewLength; i++) //Алгоритм удаления нулевых строк
                for (int j = 0; j < Arr[0].Length; j++)
                {
                    if (Arr[i][j] != 0)
                        break;
                    if (j == Arr[i].Length - 1)
                    {
                        DeleteRow(ref Arr, i, NewLength--);
                        i--;
                        if (NewLength == 0) //Длина 0 => массив состоял из нулей. Все строки нулевые = все столбцы нулевые. Нам удобнее работать построчно.
                        {
                            Arr = null;
                            return;
                        }
                    }
                }
            if (Arr.Length - NewLength != 0) //Пересоздаем массив с уплотненным размером
                Array.Resize(ref Arr, NewLength);
            NewLength = Arr[0].Length; //Переходим к удалению нулевых столбцов. Используем уже имеющуюся переменную (а что, удобно)
            for (int i = 0; i < NewLength; i++) //Алгоритм удаления нулевых столбцов
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (Arr[j][i] != 0)
                        break;
                    if (j == Arr.Length - 1)
                    {
                        DeleteColoumn(ref Arr, i, NewLength--);
                        i--;
                    }
                }
            if (Arr[0].Length - NewLength != 0) //тоже самое, что мы делали до этого, правда для каждой строки будет пересоздаваться массив и это очень не круто
                for (int i = 0; i < Arr.Length; i++)
                    Array.Resize(ref Arr[i], NewLength);
        }
        static void PrintArray(int[][] Arr)
        {
            for (int i = 0; i < Arr.Length; i++, Console.WriteLine())
                PrintArray(Arr[i]);
        }
        static void PrintArray(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
                Console.Write("{0}\t", Arr[i]);
        }
        static void InputArray(int[][] Arr)
        {
            for (ushort i = 0; i < Arr.Length; i++)
                InputArray(Arr[i]);
        }
        static void InputArray(int[] Arr)
        {
            for (ushort i = 0; i < Arr.Length; i++)
                Arr[i] = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.Write("Алгоритм: Удаление из массива все нулевые строки и столбцы.\nВведите размер кв. массива: ");
            int N = int.Parse(Console.ReadLine());
            if (N <= 0) 
                Console.WriteLine("ОШИБКА: Нельзя создать массив такой размерности.");
            else
            {
                int[][] A = new int[N][];
                for (int i = 0; i < N; i++)
                    A[i] = new int[N];
                InputArray(A);
                Console.WriteLine("Исходный массив:");
                PrintArray(A);
                Console.WriteLine();
                DeleteNulls(ref A);
                if (A == null)
                    Console.WriteLine("Массив умер. Он состоял только из одних нулей.");
                else
                {
                    Console.WriteLine("Искомый массив:");
                    PrintArray(A);
                }
            }
        }
    }
}
