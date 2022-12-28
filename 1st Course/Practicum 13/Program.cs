using System;
using System.IO;
using System.Text.RegularExpressions;

namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader fileIn = new StreamReader("C:/Users/Harvey/source/repos/P1-10/P1-10/input.txt"))
            {
                string text = fileIn.ReadToEnd();
                Console.WriteLine("Исходный текст:\n" + text);
                //Первый год (лучше через простую замену в строке)
                text = new Regex(@"C([ie])").Replace(text, "S${1}");//Ci & Ce => Si & Se
                text = new Regex(@"c([ie])").Replace(text, "s${1}");//ci & ce => si & se
                text = new Regex(@"ck|c").Replace(text, "k");       //ck & c => k
                text = text.Replace('C', 'K');
                //Второй год
                text = new Regex(@"e{2,}").Replace(text, "i");
                text = new Regex(@"o{2,}").Replace(text, "u");
                text = new Regex(@"([a-z|A-Z])\1+").Replace(text, "${1}");
                //Третий год
                text = new Regex(@"(\w+)e(\W)").Replace(text, "${1}${2}");
                //Четвертый год
                text = new Regex(@"(\b|[-,:.!?])([Aa]|[Aa]n|[Tt]h)(\b|[-,:.!?])").Replace(text, "${1}${3}");
                //Форматирование по пробелам
                text = new Regex(@"( )+").Replace(text, "${1}");
                Console.WriteLine("\nИскомый текст:\n" + text);
                using (StreamWriter fileOut = new StreamWriter("C:/Users/Harvey/source/repos/P1-10/P1-10/output.txt"))
                {
                    fileOut.Write(text);
                }
            }
        }
    }
}
