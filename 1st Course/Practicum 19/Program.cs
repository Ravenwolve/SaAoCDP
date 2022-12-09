using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace P1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader FileIn = new StreamReader("C:/Users/Harvey/source/repos/P1-10/P1-10/input.txt", Encoding.GetEncoding(1251)))
            {
                string Line;
                string[] StrFigures;
                char[] Separators = { ' ', ',', ';', '\t' };
                int n = int.Parse(FileIn.ReadLine());
                List<Figure> ResultArray = new List<Figure>(n);
                for (int i = 0; i < n && (Line = FileIn.ReadLine()) != null; i++)
                {
                    StrFigures = Line.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
                    switch (StrFigures[0][0])
                    {
                        case 'C':
                            switch (StrFigures.Length)
                            {
                                case 2: //1 + 1 (первый элемент - идентификатор объекта)
                                    ResultArray.Add(new Circle(double.Parse(StrFigures[1])));
                                    break;
                                default:
                                    ResultArray.Add(new Circle());
                                    break;
                            }
                            break;
                        case 'R':
                            switch (StrFigures.Length)
                            {
                                case 2: //1 + 1 
                                    ResultArray.Add(new Rectangle(double.Parse(StrFigures[1])));
                                    break;
                                case 3: //2 + 1
                                    ResultArray.Add(new Rectangle(double.Parse(StrFigures[1]), double.Parse(StrFigures[2])));
                                    break;
                                default:
                                    ResultArray.Add(new Rectangle());
                                    break;
                            }
                            break;
                        case 'T':
                            switch (StrFigures.Length)
                            {
                                case 2: //1 + 1
                                    ResultArray.Add(new Triangle(double.Parse(StrFigures[1])));
                                    break;
                                case 3: //2 + 1
                                    ResultArray.Add(new Triangle(double.Parse(StrFigures[1]), double.Parse(StrFigures[2])));
                                    break;
                                case 4: //3 + 1
                                    ResultArray.Add(new Triangle(double.Parse(StrFigures[1]), double.Parse(StrFigures[2]), double.Parse(StrFigures[3])));
                                    break;
                                default:
                                    ResultArray.Add(new Rectangle());
                                    break;
                            }
                            break;
                        default:
                            ResultArray[i] = null;
                            break;
                    }
                }
                ResultArray.Sort();
                foreach (var Item in ResultArray)
                    Console.WriteLine("{0}:\t{1}", Item.GetType().Name, Item);
            }
        }
    }
}