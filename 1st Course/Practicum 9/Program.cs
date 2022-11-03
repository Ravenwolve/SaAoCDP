using System;
using System.IO;
using System.Text;
namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Алгоритм: Дан файл f, компонентами которого являются символы. Переписать в файл g все знаки препинания файла f, а в файл h – все остальные символы файла f.");
            using (StreamReader FileInF = new StreamReader("C:/Users/sharovkv/source/repos/P1-10/P1-10/f.txt", Encoding.GetEncoding(1251)))
            {
                using (StreamWriter FileOutG = new StreamWriter("C:/Users/sharovkv/source/repos/P1-10/P1-10/g.txt", true), FileOutH = new StreamWriter("C:/Users/sharovkv/source/repos/P1-10/P1-10/h.txt", true))
                {
                    string Line = FileInF.ReadToEnd();
                    for (int i = 0; i < Line.Length; i++)
                    {
                        if (!char.IsPunctuation(Line[i]))
                            FileOutH.Write(Line[i]); //или лучше построчно писать?
                        else FileOutG.Write(Line[i]);
                    }
                    Console.WriteLine("Работа программы успешно завершена.");
                }
            }
        }
    }
}
