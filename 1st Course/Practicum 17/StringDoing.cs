using System;
using System.Text;

namespace P1_10
{
    internal class StringDoing
    {
        internal StringBuilder line;
        public int Length { get { return line.Length; } }
        public StringBuilder Line { set { line = new StringBuilder(Console.ReadLine()); } get { return line; } }
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
        public StringDoing ToLower() //Метод преобразования строки в верхний регистр
        {
            if (Length != 0)
                return new StringDoing(line.ToString().ToLower());
            return null;
        }
        public StringDoing ToUpper() //Метод преобразования строки в верхний регистр
        {
            if (Length != 0)
                return new StringDoing(line.ToString().ToUpper());
            return null;
        }
        public StringDoing RemovePunctuation() //Метод удаления всех знаков пунктуации
        {
            if (Length != 0)
            { //Разъединяет по знакам пунктации строки в массив строк, затем объединяет его в одну строку
                char[] separators = { ',', ':', ';', '-', '.', '?', '!' };
                return new StringDoing(string.Join("", line.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries)));
            }
            return null;
        }
        public static StringDoing operator + (StringDoing line) { return line.ToUpper(); }
        public static StringDoing operator -(StringDoing line) { return line.ToLower(); }
        public static bool operator true(StringDoing line) { return line.Length != 0; }
        public static bool operator false(StringDoing line) { return line.Length == 0; }
        public static bool operator &(StringDoing line_1, StringDoing line_2) { return line_1 == line_2; }
        public override string ToString() { return line.ToString(); }
        public static implicit operator StringBuilder(StringDoing line) { return line.Line; }
    }
}
