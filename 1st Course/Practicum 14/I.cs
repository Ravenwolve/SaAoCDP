using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace P1_10
{
    struct SPoint
    {
        public double x, y, z;
        public SPoint(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static bool IsInOneLot(SPoint FirstPoint, SPoint SecondPoint, uint Radius)
        {
            return ((FirstPoint.x - SecondPoint.x) * (FirstPoint.x - SecondPoint.x)
                + (FirstPoint.y - SecondPoint.y) * (FirstPoint.y - SecondPoint.y) +
                (FirstPoint.z - SecondPoint.z) * (FirstPoint.z - SecondPoint.z)) <= Radius * Radius;

        }
    }
    internal class Program
    {
        static double Mod(double Number)
        {
            if (Number >= 0)
                return Number;
            else return -Number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Алгоритм: Найти такую точку, что шар радиуса R с центром в этой точке содержит максимальное число точек заданного множества.");
            using (StreamReader FileIn = new StreamReader("C:/Users/Harvey/source/repos/P1-10/P1-10/input.txt", Encoding.GetEncoding(1251))) //C:/Users/sharovkv/source/repos/P1-10/P1-10/f.txt
            {
                string Line;
                string[] Nums;
                char[] Separators = { ' ', ',', ';' };
                SPoint Temp = new SPoint();
                List<SPoint> Points = new List<SPoint>();
                while ((Line = FileIn.ReadLine()) != null)
                {
                    Nums = Line.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
                    Temp.x = double.Parse(Nums[0]);
                    Temp.y = double.Parse(Nums[1]);
                    Temp.z = double.Parse(Nums[2]);
                    Points.Add(Temp);
                }
                Console.Write("Точки успешно считаны. Введите значение радиуса R: ");
                uint R = uint.Parse(Console.ReadLine());
                short Counter = -1, MaxCounter = 0;
                foreach (SPoint FirstItem in Points)
                {
                    foreach (SPoint SecondItem in Points)
                        if (SPoint.IsInOneLot(FirstItem, SecondItem, R))
                            Counter++;
                    if (Counter > MaxCounter)
                    {
                        MaxCounter = Counter;
                        Temp = FirstItem;
                    }
                    Counter = -1;
                }
                if (MaxCounter == 0)
                    Console.WriteLine("Таких точек не найдено.");
                else Console.WriteLine("Найдена точка ({0};{1};{2}). Количество точек, находящихся в радиусе этой точки: {3}", Temp.x, Temp.y, Temp.z, MaxCounter);
            }
        }
    }
}

