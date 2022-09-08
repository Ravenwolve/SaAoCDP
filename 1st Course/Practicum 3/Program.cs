using System;
namespace P1_10 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Все четные числа из диапазона от А до В, кратные трем.");
            Console.Write("Введите число А: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = int.Parse(Console.ReadLine());
            if (B < A)
            {
                int temp = A;
                A = B;
                B = A;
            }
            if (A % 6 != 0)
            {
                A += 6 - (A % 6);
            }
            for (int i = A; i <= B; i += 6)
                Console.Write("{0} ", i);
        }
    }
}