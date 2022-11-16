using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P1_10
{
    internal class Program
    {
        struct Employee
        {
            public string Surname, Name, Lastname;
            public ushort BeginningDate;
            public string Function;
            public uint Wage;
            public byte ExperienceYears;
            public Employee(string Surname, string Name, string Lastname, ushort BeginningDate, string Function, uint Wage, byte ExperienceYears)
            {
                this.Surname = Surname;
                this.Name = Name;
                this.Lastname = Lastname;
                this.BeginningDate = BeginningDate;
                this.Function = Function;
                this.Wage = Wage;
                this.ExperienceYears = ExperienceYears;
            }
        }
        static void Main(string[] args)
        {
            using (StreamReader FileIn = new StreamReader("C:/Users/Harvey/source/repos/P1-10/P1-10/input.txt", Encoding.GetEncoding(1251)))
            {
                using (StreamWriter FileOut = new StreamWriter("C:/Users/Harvey/source/repos/P1-10/P1-10/output.txt", true))
                {
                    char[] Separators = { ' ', ',', '.', ';' };
                    string[] Data;
                    List<Employee> Employees = new List<Employee>();
                    Employee Temp;
                    string Line;
                    while ((Line = FileIn.ReadLine()) != null)
                    {
                        Data = Line.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
                        Temp.Surname = Data[0];
                        Temp.Name = Data[1];
                        Temp.Lastname = Data[2];
                        Temp.BeginningDate = ushort.Parse(Data[3]);
                        Temp.Function = Data[4];
                        Temp.Wage = uint.Parse(Data[5]);
                        Temp.ExperienceYears = byte.Parse(Data[6]);
                        Employees.Add(Temp);
                    }
                    var Result =
                        from Emp in Employees
                        group Emp by Emp.Function into Groups
                        select Groups;
                    foreach (var Group in Result)
                    {
                        FileOut.WriteLine(Group.Key);
                        foreach (Employee Item in Group)
                            FileOut.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", Item.Surname, Item.Name, Item.Lastname, Item.BeginningDate, Item.Function, Item.Wage, Item.ExperienceYears);
                        FileOut.WriteLine();
                    }
                    /*
                     Sharov Kirill Vladimirovich 2021 Programmer 75000 5
Sergeev Alexei Andreevich 2017 Designer 80000 9
Androsov Pyotr Vasilievich 2020 Programmer 100000 8
Leibniz Anton Borisovich 2019 System-Admin 45000 3
Fyodorov Miron Yanovich 2015 Designer 89500 12
                     */
                }
            }
        }
    }
}
