using System;
namespace P1_10 {
    internal class Program {
        const short curyear = 2022;
        static void Main(string[] args) {
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет?");
            short age = byte.Parse(Console.ReadLine());
            Console.WriteLine(name + ", ты родился в {0}", curyear - age);
        }
    }
}
