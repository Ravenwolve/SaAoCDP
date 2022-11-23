using System;
using System.Text;

namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringDoing example = new StringDoing("На ДвОрЕ трава, на траве дрова - не руби дрова на траве ДВОРА!");
            Console.WriteLine(example);
            Console.WriteLine(StringDoing.CountSpaces(example));
            example.ToLower();
            Console.WriteLine(example);
            example.RemovePunctuation();
            Console.WriteLine(example);
            example.Line = new StringBuilder("f");
        }
    }
}