using System;
using System.Collections.Generic;

namespace P1_10
{
    internal class Program
    {
        static int FindAmountOfUppercaseWords(string String)
        {
            List<string> Words = new List<string>();
            for (int i = 0, j = 0; j < String.Length; j++)
                if (!char.IsLetter(String[j]))
                {
                    if (i != j)
                        Words.Add(String.Substring(i, j - i));
                    i = j + 1;
                }
            int Counter = Words.Count;
            foreach (string ItemStr in Words)
                foreach (char ItemCh in ItemStr)
                    if (char.IsLower(ItemCh))
                    {
                        Counter--;
                        break;
                    }
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