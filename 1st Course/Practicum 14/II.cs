using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace P1_10
{
    struct Student : IComparable<Student>
    {
        public string Surname, Name, Lastname;
        public byte Course;
        public ushort Group;
        public double Result;
        public Student(string Surname, string Name, string Lastname, byte Course, ushort Group, double Result)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Lastname = Lastname;
            this.Course = Course;
            this.Group = Group;
            this.Result = Result;
        }
        public int CompareTo(Student Object) { return this.Result.CompareTo(Object.Result); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Алгоритм: Найти такую точку, что шар радиуса R с центром в этой точке содержит максимальное число точек заданного множества.");
            using (StreamReader FileIn = new StreamReader("C:/Users/Harvey/source/repos/P1-10/P1-10/input.txt", Encoding.GetEncoding(1251))) //C:/Users/sharovkv/source/repos/P1-10/P1-10/f.txt
            {
                string Line;
                string[] Nums;
                char[] Separators = { ' ', ';', '(', ')', '-' };
                Student Temp = new Student();
                List<Student> Students = new List<Student>();
                while ((Line = FileIn.ReadLine()) != null)
                {
                    Nums = Line.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
                    Temp.Surname = String.Copy(Nums[0]);
                    Temp.Name = String.Copy(Nums[1]);
                    Temp.Lastname = String.Copy(Nums[2]);
                    Temp.Course = byte.Parse(Nums[3]);
                    Temp.Group = ushort.Parse(Nums[4]);
                    Temp.Result = double.Parse(Nums[5]);
                    Students.Add(Temp);
                }
                Nums = null;
                Console.WriteLine("Данные студентов успешно считаны. Процесс сортировки...");
                Students.Sort();
                Console.WriteLine("Сортировка данных завершена. Процесс вывода данных в output.txt...");
                using (StreamWriter FileOut = new StreamWriter("C:/Users/Harvey/source/repos/P1-10/P1-10/output.txt", true))
                {
                    Temp = Students[0];
                    byte Counter = 1;
                    foreach (Student Item in Students)
                    {
                        if (Item.CompareTo(Temp) == 0) ;
                        else if (Counter < 3)
                        {
                            Counter++;
                            Temp = Item;
                        }
                        else break;
                        FileOut.WriteLine("{0}, {1} {2} {3} ({4}) - {5};", Item.Surname, Item.Name, Item.Lastname, Item.Course, Item.Group, Item.Result);
                    }
                    Console.WriteLine("Данные о студентах успешно выведены в файл output.txt.");
                }
            }
        }
    }
}


