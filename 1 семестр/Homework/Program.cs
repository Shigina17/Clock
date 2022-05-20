using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа");
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Введите ваше имя: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + UserName);


            Console.WriteLine("Домашняя работа 2.1");
            double a, b;
            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToDouble(a) / Convert.ToDouble(b));

            Console.WriteLine("Домашняя работа 2.2");
            Console.WriteLine("Решение квадратного уравнения");
            Console.WriteLine("Введите переменную a, b, c:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine()); 
            double c = Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет вещественных корней");
            }
            else if (d == 0)
            {
                double x = -b / 2 / a;
                Console.WriteLine("х = " + x);
            }
            else
            { 
                double x1 = (-b + Math.Sqrt(d)) / 2 / a;
                double x2 = (-b - Math.Sqrt(d)) / 2 / a;
                Console.WriteLine("х1 = " + x1 + "; x2 = " + x2);
            }
            
            Console.ReadLine();

        }
    }
}
