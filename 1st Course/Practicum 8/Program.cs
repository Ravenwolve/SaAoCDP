using System;

namespace P1_10
{
    internal class Program
    {
        static int FindAmountOfUppercaseWords(string String)
        {
            int Counter = 0;
            char[] Separators = { ' ', '\n', '\r', '"', ':', ',', '!', '?', ';', '-', '+', '=', '(', ')', '$', '%', '*', '&', '/',
                                  '@', '\t', '\v', '[', ']', '{', '}', '<', '>', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string[] Words = String.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string Item in Words)
                if (Item == Item.ToUpper())
                    Counter++;
            return Counter;
        }
        static void Main(string[] args)
        {
            Console.Write("Алгоритм: Найти количество слов, состоящих только из прописных букв.\nВведите строку: ");
            string MyStr = Console.ReadLine();
            //    НА?!ДВОРЕ ТРАВа, на ТРАВЕ ДРоВА, НЕ?,!Руби ДРОВА на ТРАВЕ двора!
            //Вывод: 6
            Console.WriteLine(FindAmountOfUppercaseWords(MyStr));
        }
    }
}
