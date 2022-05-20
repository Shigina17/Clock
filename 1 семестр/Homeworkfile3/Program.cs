using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkfile3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Задание 1.1");
            Console.WriteLine("Введите вещественное число: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num < 0)
            {
                num = -num;
            }
            Console.WriteLine($"Абсолютная величина = {num}");


            
            Console.WriteLine("Задание 1.2");
            Console.WriteLine("Введите первое число: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double num1 = n1, num2 = n2;
            if (num1 < 0)
            {
                num1 = -n1;
            }
            if (num2 < 0)
            {
                num2 = -n2;
            }
            if (num1 > num2)
            {
                n1 /= 2;
            }
            Console.WriteLine($"Результат: {n1}");
           


            Console.WriteLine("Задание 1.2");
            Console.WriteLine("С каким животным встретилась лягушка: ");
            string animal = Console.ReadLine();
            string mouthSize = "wide";
            if (animal.ToLower() == "аллигатор")
            {
                mouthSize = "small";
            }
            else
            {
                mouthSize = "wide";
            }
            Console.WriteLine(mouthSize);


            
            Console.WriteLine("Задание 1.4");
            Console.WriteLine("Введите название напитка: "); 
            string str = Console.ReadLine().ToLower();
            string drink = str.ToLower();
            try
            {
                switch (drink)
                {
                    case "jabroni":
                        Console.WriteLine("Patron Tequila");
                        break;
                    case "school counselor":
                        Console.WriteLine("Anything with Alcohol");
                        break;
                    case "programmer":
                        Console.WriteLine("Hipster Craft Beer");
                        break;
                    case "bike gand member ":
                        Console.WriteLine("Moonshine");
                        break;
                    case "politician":
                        Console.WriteLine("Your tax dollar");
                        break;
                    case "rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

            

            Console.WriteLine("Задание 1.5");
            Console.WriteLine("Введите строку: ");
            str = Console.ReadLine();
            string substring = "English";
            bool b = str.Contains(substring);
            if (b)
            {
                Console.WriteLine(b);
            }
            else
            {
                b = false;
                Console.WriteLine(b);
            }
            


            Console.WriteLine("Задание 2.1");
            double a1 = 3, a2 = a1 * a1, a3 = a2 * a1, a4 = a2 * a2, a5 = a3 * a2, a6 = a3 * a3, a7 = a5 * a2, a8 = a4 * a4;
            double numerator = 1 + a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8;
            double denominator = a8;
            double result = numerator / denominator;
            Console.WriteLine($"Результат сложения: 1 + 1/3 + 1/3^2 + ... + 1/3^8 = {result}");



            Console.WriteLine("Задание 2.2");
            double x = 1; 
            double y = 1;
            double a = 1;
            int i;
            for (i = 1; i <= 100; i++)
            {
                a *= -1;
                x += (double)a / i;
                y += 1 / i;
            }
            Console.WriteLine($"После 100-го этапа расстояние до дома составит {x} км");
            
            

            Console.WriteLine("Задание 2.3");
            float[] januaryPrecipitations = new float[31], marchPrecipitations = new float[31];
            double sum = 0;
            for (i = 0; i < januaryPrecipitations.Length; i++)
            {
                januaryPrecipitations[i] = rnd.Next(10, 100) / 10;
                sum += januaryPrecipitations[i];
            }
            Console.WriteLine("Среднее количество осадков в феврале составляет = " + sum / 31);
            sum = 0;
            for (i = 0; i < marchPrecipitations.Length; i++)
            {
                marchPrecipitations[i] = rnd.Next(10, 100) / 10;
                sum += marchPrecipitations[i];
            }
            Console.WriteLine("Среднее количество осадков в марте составляет = " + sum / 31);


            
            Console.WriteLine("Задание 3.1");
            num1 = 1; num2 = 2; double div1 = 1; double div2 = 1;
            while (Math.Abs(num2 / div2 - num1 / div1) > 0.001)
            {
                num = num2; double div = div2;
                div2 += div1;
                num2 += num1;
                num1 = num;
                div1 = div;
            }
            Console.WriteLine($"{num2}/{div2}\nЧислитель= {num2} Делитель= {div2}");



            Console.WriteLine("Задание 3.2");
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            a = 1;
            while (a * a <= n)
            {
                a++;
            }
            Console.WriteLine("Первое число больше n = " + a * a);
            

            
            Console.WriteLine("Задание 3.3");
            n = 100;
            while (n >= 80)
            {
                Console.WriteLine(n);
                n--;
            }
            n = 100;
            do
            {
                Console.WriteLine(n);
                n--;
            } while (n >= 80);


            
            Console.WriteLine("Задание 3.4");
            for (i = 5000; i % 39 != 0; i--)
            {
            Console.WriteLine($"Число {i} не превышает 5000 и делиться на 39");
            }
            


            Console.WriteLine("Задание 3.5а");
            int t = 5;
            for (i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(t + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 3.5б");
            t = 1;
            for (i = 5; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(t + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
