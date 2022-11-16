using System;
using System.IO;
using System.Linq;
using System.Text;

namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader FileIn = new StreamReader("C:/Users/Harvey/source/repos/P1-10/P1-10/input.txt", Encoding.GetEncoding(1251)))
            {
                char[] Separators = { ' ', ',', '.', ';' };
                string[] File = FileIn.ReadToEnd().Split(Separators, StringSplitOptions.RemoveEmptyEntries);
                int[] Numbers = new int[File.Length];
                for (int i = 0; i < File.Length; i++)
                    Numbers[i] = int.Parse(File[i]);
                //var Numbers = Convert.ToInt32(File);
                var Result =
                    from n in Numbers
                    where (n > 99 && n < 1000) || (n > -1000 && n < -99)
                    select n - 100;
                foreach (int Item in Result)
                    Console.Write("{0} ", Item);
                //521 52 754 23 -259 -1234 5256 21 23 99 021 123 45 2
            }
        }
    }
}
