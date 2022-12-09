using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Schema;

namespace P1_10
{
    internal class StringDoing
    {
        static StringBuilder line;
        public int Length { get { return line.Length; } }
        public StringBuilder Line { set { line = value; } get { return line; } }
        public StringDoing() { line = new StringBuilder(""); }
        public StringDoing(string StringData) { line = new StringBuilder(StringData); }
        public int this[int i] { get { return line[i]; } }
        public static int CountSpaces(StringDoing line) //Метод подсчета количества пробелов
        {
            int count = 0;
            for (int i = 0; i < line.Length; i++)
                if (line[i] == ' ')
                    count++;
            return count;
        }
        public void ToLower() //Метод преобразования строки в верхний регистр
        {
            if (Length != 0)
            {
                char[] temps = new char[line.Length];
                for (int i = 0; i < Length; i++)
                    temps[i] = char.ToLower(line[i]);
                line = new StringBuilder(new string (temps));
            }
        }
        public void RemovePunctuation() //Метод удаления всех знаков пунктуации
        {
            if (Length != 0)
            {
                char[] separators = { ',', ':', ';', '-', '.', '?', '!' };
                Line = new StringBuilder(string.Join("", line.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries)));
            }
        }
        public override string ToString() { return line.ToString(); }
    }
}