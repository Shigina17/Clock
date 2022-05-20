using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfromfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание А1.1");
            Console.WriteLine("Сколько прошло секунд? ");
            double sec = double.Parse(Console.ReadLine());
            double hour = (sec / 3600);
            Console.WriteLine("Прошло " + hour + " полных часов");
            Console.WriteLine("Сколько прошло секунд? ");
            hour = double.Parse(Console.ReadLine());
            double min = (hour / 60);
            Console.WriteLine("Прошло " + min + " полных минут");
            Console.WriteLine("Сколько прошло секунд? ");
            min = double.Parse(Console.ReadLine());
            sec = (min / 60);
            Console.WriteLine("Прошло " + sec + " полных секунд");


            Console.WriteLine("Задание А1.2");
            int a = 543, b = 130, c = 130;
            int S = a * b;
            int S1 = c * c;
            int result = S / S1;
            Console.WriteLine("Ответ:  " + result);


            Console.WriteLine("Задание А1.3");
            Console.WriteLine("Сейчас 2020 год");
            Console.WriteLine("Номер последнего месяца = ");
            string[] month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int n = Convert.ToInt32(Console.ReadLine()); // вводим номер месяца
            Console.WriteLine("Прошел " + month[n - 1]); // выводит предыдущий месяц
            Console.WriteLine("Сейчас " + month[n]); // выводит текущий месяц

             
            Console.WriteLine("Задание А1.4");
            int tens, ones, sum, prod;
            Console.WriteLine("Введите двухначное число: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 99 && n < 10)
            {
                Console.WriteLine("Ошибка. Введите число от 10 до 99");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            tens = n / 10;
            ones = n % 10;
            sum = tens + ones;
            prod = tens * ones;
            {
                Console.WriteLine("А) Число десятков: " + tens);
                Console.WriteLine("Б) Число единиц: " + ones);
                Console.WriteLine("В) Сумма цифр числа: " + sum);
                Console.WriteLine("Г) Произведение цифр числа: " + prod);
            }
            Console.ReadKey();

            Console.WriteLine("Задание А1.5");
            int x, y, z;
            Console.WriteLine("Введите трехзначное число: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 999 && n < 100)
            {
                Console.WriteLine("Ошибка. Введите число от 100 до 999");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            x = (n / 10) % 10;
            y = n % 10;
            z = n / 100;
            Console.WriteLine($"Если зачеркнуть левую цифру и приписат ее в конце, получится: {x}{y}{z}");
            Console.ReadKey();


            Console.WriteLine("Задание А1.6");
            int num, priv;
            y = 237;
            num = y / 100;
            priv = y % 100;
            x = priv * 10 + num;
            Console.WriteLine($"Ответ: {x}");


            Console.WriteLine("Задание А1.7");
            int a2, a1, b2, b1, c1, c2;
            Console.WriteLine("a2 = ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a1 = ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b2 = ");
            b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b1 = ");
            b1 = Convert.ToInt32(Console.ReadLine());
            c2 = a2 + a1;
            c1 = b2 + b1;
            Console.WriteLine($"c = {c2 + c1}");
            Console.ReadKey();


            Console.WriteLine("Задание А1.8");
            Console.WriteLine("k, кратное трем: ");
            byte k = Convert.ToByte(Console.ReadLine());
            int a3 = Convert.ToInt32(value: Console.ReadLine());
            a1 = k / 3 % 10; // k кратно 3
            a2 = 1; // k - одно из чисел 1, 4, 7, ...
            a3 = (k + 2) / 30; // k - одно из чисел 2, 5, 8, ...
            Console.WriteLine($"k-ая цифра = {a1}");
            Console.WriteLine("\nk = 1, 4, 7, ... : ");
            k = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"k-ая цифра = {a2}");
            Console.WriteLine("\nk = 2, 5, 8, ... : ");
            k = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"k-ая цифра = {a3}");
            Console.ReadKey();


            Console.WriteLine("Задание А1.9");
            bool A, B, C, X, Y, Z;
            A = true;
            B = false;
            C = false;
            X = A | B;
            Y = A & B;
            Z = B | C;
            Console.WriteLine($"{X}, {Y}, {Z}");


            Console.WriteLine("Задание А1.10");
            Console.WriteLine("Введите логические значения для X, Y, Z(true или false)");
            Console.Write("Логическое значение X: ");
            X = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Логическое значение Y: ");
            Y = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Логическое значение Z: ");
            Z = Convert.ToBoolean(Console.ReadLine());
            bool l = (!(X || Y) && (!X || !Z));
            bool m = (!X && Y) || (X && !Z);
            bool d = X || !Y && !(X || !Z);
            Console.WriteLine($"А: { l}");
            Console.WriteLine($"Б: { m}");
            Console.WriteLine($"В: { d}");
        }
    }
}
