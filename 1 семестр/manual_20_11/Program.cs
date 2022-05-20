using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manual_20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1");
            Console.WriteLine("Введите строку: ");
            ACipher a = new ACipher(Console.ReadLine());
            Console.WriteLine("Закодированная строка: ");
            Console.WriteLine(a.Encode());



            Console.WriteLine("Вторая часть упражнения");
            Console.WriteLine("Введите i: ");
            int i;
            if (int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Введите строку: ");
                BCipher b = new BCipher(Console.ReadLine(), i);
                Console.WriteLine(b.Decode());
            }



            Console.WriteLine("Домашнее задание 10.1");
            Console.WriteLine(new Circle(10).PrintSquare());
            Console.ReadKey();
        }
    }
}
