using System;
namespace P1_10 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Проверка: Делится ли сумма цифр заданного трехзначного числа на другое заданное число.\nВведите трехзначное число: ");
            short Number = short.Parse(Console.ReadLine());
            Console.WriteLine("Введите число-делитель: ");
            byte A = byte.Parse(Console.ReadLine());
            bool Answer = (Number % 10 + Number / 10 + Number / 100) % A == 0 ? true : false;
            Console.WriteLine(Answer);
        }
    }
}
